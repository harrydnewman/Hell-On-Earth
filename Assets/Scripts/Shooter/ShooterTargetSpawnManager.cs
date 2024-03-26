using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterTargetSpawnManager : MonoBehaviour
{
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMyThing", 2, 1f);


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void xPosYTilt()
    {

    }

    void SpawnMyThing()
    {
        float xPosition;
        float yTilt;
        xPosition = Random.Range(-2, 31);
        float xTilt;
        float zTilt;
        xTilt = Random.Range(-10, -20);
        //Debug.Log(xTilt);
        yTilt = Random.Range(-40, 40);
        zTilt = Random.Range(-30, 30);
        //Debug.Log(zTilt);
        transform.rotation = Quaternion.Euler(xTilt, yTilt, zTilt);
        Vector3 spawnPos = new Vector3(xPosition, 1, 33);
        Instantiate(projectilePrefab, spawnPos, transform.rotation);
    }

}
