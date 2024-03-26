using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene1Timer : MonoBehaviour
{
    private float count;
    private float bcount;
    public float timer;
    public float FinishTime = 200f;
    public float CountTime = 210f;
    //private float Zero = 0f;
    //private bool timerEnd;
    public SceneLoader sceneloader;



    void Start()
    {
        //timerEnd = false;
        count = 0;
        

    }
    void Update()
    {
        Debug.Log(timer);
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = 0;
            if (timer == 0)
            {
                LoadNextScene(); 
            }
        }

    }
    public void StartTimer()
    {
        count++;
        if (count == 1)
        {
            Debug.Log("Start Timer");
            timer = 5f;
        }

    }
    public void LoadNextScene()
    {
        bcount++;
        if (bcount == 1)
        {
            sceneloader.LoadScene();
        }
        
    }

    
}