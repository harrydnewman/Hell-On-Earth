using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CPCountdown : MonoBehaviour
{
    public float countdown;
    public float seconds;
    private float count;
    public CPThrowBall cpThrowBall;
    public CPTimer cptimer;
    public GameObject PlayerCups;
    private bool counterEnd;
    public GameObject FratBros;
    
    public Camera AimCamera;
    public Camera EnemyCupsCamera;
    [SerializeField] public TMP_Text countdownText;
    //PlayerBall(Clone)

    // Start is called before the first frame update
    void Start()
    {
       
        counterEnd = false;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown > 0)
        {
            countdown -= Time.deltaTime;
            
        }
        else
        {
            countdown = 0;
            CounterEnd(counterEnd);
        }
        countdownText.text = countdown.ToString("f2");
    }
    public void CounterStart(float seconds)
    {
        countdown = seconds;
        count = 0;
        if (countdown > 0.5)
        {
            counterEnd = true;
        }
        
    }

    public void CounterEnd(bool end)
    {
       
        if (end == true && (GameObject.Find("PlayerBall(Clone)") == null))
        {
            count += 1;
            if (count == 1)
            {
                AimCamera.gameObject.SetActive(false);
                EnemyCupsCamera.gameObject.SetActive(false);
                PlayerCups.gameObject.SetActive(true);
                FratBros.gameObject.SetActive(true);
                cpThrowBall.ResetClickCounter();
               


            }
        }
    }
}

