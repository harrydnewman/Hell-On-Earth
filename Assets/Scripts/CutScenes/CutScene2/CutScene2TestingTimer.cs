using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene2TestingTimer : MonoBehaviour
{
    private float count;
    public float timer;
    private bool timerEnd;
    public SceneLoader sceneloader;
    public GameObject TrapDoors;


    void Start()
    {
        timerEnd = false;
        count = 0;
        //TimerStart(20f);

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(timer);
        if (timer > 0)
        {
            timer -= Time.deltaTime;

            if (timer < 7 && timer > 6)
            {
                Debug.Log("timer is less than 14");
                TrapDoors.gameObject.SetActive(false);

            }
        }
        // }
        //if (timer < 5 && timer > 4)
        //{
        //    Debug.Log("Timer is less than 5");
        //    timer -= Time.deltaTime;

        else
        {
            timer = 0;
            if (timer == 0)
            {
                Debug.Log("Timer has ended");
                TimerEnd(timerEnd);
            }

        }
    }

    public void TimerStart(float time)
    {


        timer = time;
        //Debug.Log("Timer Started");
        count = 0;
        if (timer > 0.5)
        {
            timerEnd = true;
        }
    }
    public void TimerEnd(bool end)
    {

        if (end == true)
        {
            count += 1;
            if (count == 1)
            {
                //Debug.Log("Timer Ended");
                sceneloader.LoadScene();
                return;
            }

            else if (count > 1)
            {
                count = 2;
            }



        }
    }
}
