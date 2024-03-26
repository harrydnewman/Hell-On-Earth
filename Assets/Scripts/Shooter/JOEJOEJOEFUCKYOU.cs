using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JOEJOEJOEFUCKYOU : MonoBehaviour
{
    public float count;
    public float timer;
    public bool timerEnd;
    public GameObject Crosshair;
    public GameObject Timer;
    public GameObject Score;
    public GameObject LoadingScreensParent;
    public GameObject WinLoadingScreen;
    public GameObject LossLoadingScreen;
    public GameObject MainLoadingScreen;
    // Start is called before the first frame update
    void Start()
    {
        timerEnd = false;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timer);
        //Debug.Log(timerEnd);
        //Debug.Log(count);
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            ThisTimerEnd(timerEnd);

        }

        //else if (timer < 0)
        //{

        //}
    }
    public void ThisTimerStart(float time)
    {

        Debug.Log(time);
        timer = time;
        Debug.Log(timer);
        count = 0;
        if (timer > 0.5)
        {
            timerEnd = true;
        }

    }
    public void ThisTimerEnd(bool end)
    {

        if (end == true)
        {
            count += 1;
            if (count == 1)
            {
                WinScreen();
                return;
            }

            else if (count > 1)
            {
                count = 2;
            }



        }
    }
    public void WinScreen()
    {
        if (timer < 4)
        {
            Debug.Log("You Win!");
            //Debug.Log(timer);
            Crosshair.SetActive(false);
            Timer.SetActive(false);
            Score.SetActive(false);
            LoadingScreensParent.SetActive(true);
            LossLoadingScreen.SetActive(false);
            WinLoadingScreen.SetActive(true);
            MainLoadingScreen.SetActive(false);
            //figure out what this time should be
            if (timer < 1)
            {
                Debug.Log("Heyyyyyy");
                WinLoadingScreen.SetActive(false);
                MainLoadingScreen.SetActive(true);
                return;
            }
        }
    }

}





