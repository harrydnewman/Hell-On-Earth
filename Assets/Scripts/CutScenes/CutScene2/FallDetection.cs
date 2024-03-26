using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetection : MonoBehaviour
{

    public CutScene2TestingTimer ct2tt;
    // public GameObject Player;
    private float FallDetector = 1f;
    private float count;
    private float bcount;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
        count = 0;
        bcount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position);
        //Debug.Log(transform.position.y);
        if (transform.position.y < FallDetector)
        {
            bcount++;
            if (bcount == 1)
            {

                StartSceneTimer();
            }
        }
    }
    private void StartSceneTimer()
    {
        count++;
        if (count == 1)
        {
            count = 1;
            if (count == 1)
            {
                ct2tt.TimerStart(30f);
            }
        }
        if (count > 1)
        {
            count = 2;
        }
    }

}
