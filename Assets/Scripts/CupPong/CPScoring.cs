using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPScoring : MonoBehaviour
{
    
    public CPThrowBall cpThrowBall;
    public CPLoadingScreen cpLoadingScreen;
    public CPKeepScore cpKeepScore;

    public float Number;
    public float timer = 1;
    public float time;
    public bool timerEnd;
    public float point = 1;

    void Start()
    {
        //EnemyScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        Debug.Log("Ball has entered Cup!");
        if (other.name == "PlayerBall(Clone)")
        {
            Debug.Log("PlayerBall(Clone) Destroyed");
            Destroy(other.gameObject);
            Destroy(gameObject);
            cpKeepScore.AddToPlayerScore(point);
        }
        else if (other.name == "PlayerBall")
        {
            Debug.Log("PlayerBall Destroyed");
            Destroy(other.gameObject);
            Destroy(gameObject);
            cpKeepScore.AddToPlayerScore(point);
            //make code to destroy ball after certain amount of time
        }
        else if (other.name == "EnemyBall1")
        {

            Destroy(other.gameObject);
            Destroy(gameObject);
            cpKeepScore.AddToEnemyScore(point);
        }
        else if (other.name == "EnemyBall2")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            cpKeepScore.AddToEnemyScore(point);
        }
        else if (other.name == "EnemyBall3")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            cpKeepScore.AddToEnemyScore(point);

        }
        else if (other.name == "EnemyBall4")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            cpKeepScore.AddToEnemyScore(point);
        }
        else if (other.name == "EnemyBall5")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            cpKeepScore.AddToEnemyScore(point);

        }
        else if (other.name == "EnemyBall6")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            cpKeepScore.AddToEnemyScore(point);

        }
        else if (other.name == "EnemyBall7")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            cpKeepScore.AddToEnemyScore(point);

        }
        else if (other.name == "EnemyBall8")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            cpKeepScore.AddToEnemyScore(point);

        }
        else if (other.name == "EnemyBall9")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            cpKeepScore.AddToEnemyScore(point);

        }
        else if (other.name == "EnemyBall10")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            cpKeepScore.AddToEnemyScore(point);

        }
    }

}




