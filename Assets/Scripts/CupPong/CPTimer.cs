using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPTimer : MonoBehaviour
{
    public float timer;
    public float time;
    private float count;
    public Camera EnemyCupsCamera;
    public bool timerEnd;
    public CPScoring cpScore;
    public CPThrowBall cpThrowBall;
    public GameObject ballClone;
    public GameObject PlayerCups;
    // Start is called before the first frame update
    void Start()
    {
        
        timerEnd = false;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(timerEnd);
        //Debug.Log(count);
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            //Debug.Log("Timer:");
            //Debug.Log(timer);
        }

        else
        {
            timer = 0;
            TimerEnd(timerEnd);
        }
    }
    public void TimerStart(float time)
    {
        //Debug.Log("Value Recieved, Timer Starting");
        timer = time;
        count = 0;
        if (timer > 0.5)
        {
            timerEnd = true;
        }

    }
    public void TimerEnd(bool end)
    {
        //Debug.Log("Timer End");
        if (end == true)
        {
            count += 1;
            if (count == 1)
            {
                ballClone = GameObject.Find("PlayerBall(Clone)");
                EnemyCupsCamera.gameObject.SetActive(false);
                PlayerCups.gameObject.SetActive(true);
                if (GameObject.Find("PlayerBall(Clone)") != null)
                {
                    PlayerCups.SetActive(true);
                    Destroy(ballClone.gameObject);
                    cpThrowBall.EnemyTurn(0);
                    return;
                }
                else if (GameObject.Find("PlayerBall(Clone)") == null)
                {
                    cpThrowBall.EnemyTurn(0);
                    return;
                }
                if (count > 1)
                {
                    count = 2;
                }




            }
        }
    }
}
