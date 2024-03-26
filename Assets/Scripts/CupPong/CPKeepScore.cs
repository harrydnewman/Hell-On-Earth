using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPKeepScore : MonoBehaviour
{
    public float PlayerScore;
    public float EnemyScore;
    public float ScoreToWin = 10;
    public CPLoadingScreen cpLoadingScreen;
    public SceneLoader sceneloader;
    public SceneLoader2 sceneloader2;
    public CupPongAudio cpa;
    

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(EnemyScore);
    }
    public void AddToPlayerScore(float point)
    {
        cpa.PlayerScoresAudio();
        PlayerScore++;
       
        if (PlayerScore == ScoreToWin)
        {
            cpLoadingScreen.PlayerWins();
            sceneloader.LoadScene();

        }
    }
    public void AddToEnemyScore(float point)
    {
        cpa.EnemyScoresAudio();
        EnemyScore++;
        if (EnemyScore == ScoreToWin)
        {
            cpLoadingScreen.EnemyWins();
            sceneloader2.LoadScene();
        }
    }

}
