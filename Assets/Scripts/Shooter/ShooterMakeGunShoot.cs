using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterMakeGunShoot : MonoBehaviour
{
    //how much damage the gun does
    public int gunDamage = 1;
    //how fast it can shoot
    public float fireRate = .25f;
    //how far it can shoot
    public float weaponRange = 60f;
    //force which will be applied by the shit (probably wont use this for my project)
    public float hitForce = 100f;
    //where the gun end points to
    public Transform gunEnd;
    
    

    private Camera fpscam;
    //how long the lazer is visable for
    private WaitForSeconds shotDuration = new WaitForSeconds(0.02f);
    public AudioSource gunAudio;
    public AudioClip lasersound;
    private LineRenderer laserline;
    //how long it takes before the player can fire again
    private float nextFire;
    //private float playerScore = 0;
    

    void Start()
    {
        laserline = GetComponent<LineRenderer>();

        gunAudio = GetComponent<AudioSource>();
        fpscam = GetComponentInParent<Camera>();
    }

    void Update()
    {   //if the player is allowed to fire
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            gunAudio.PlayOneShot(lasersound, 1f);
            nextFire = Time.time + fireRate;

            StartCoroutine(ShotEffect());

            //allows player to aim
            Vector3 rayOrigin = fpscam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            laserline.SetPosition(0, gunEnd.position);

            if (Physics.Raycast(rayOrigin, fpscam.transform.forward, out hit, weaponRange))
            {
                laserline.SetPosition(1, hit.point);

                ShooterKillTarget health = hit.collider.GetComponent<ShooterKillTarget>();

                if (health != null)
                {
                    health.Damage(gunDamage);
                }

                if (hit.rigidbody != null)
                {   //MOVES THE BOX
                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                }
            }
            else
            {
                laserline.SetPosition(1, rayOrigin + (fpscam.transform.forward * weaponRange));
            }


        }
    }

    private IEnumerator ShotEffect()
    {
        //gunAudio.Play();
        laserline.enabled = true;
        yield return shotDuration;
        laserline.enabled = false;

    }
}
