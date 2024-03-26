using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ShooterWinLoss : MonoBehaviour
{
    private float timeValue = 30;
    public Text timerText;
    public Text scoreText;
    public float playerScore = 0;
    public SceneLoader sceneloader;
    public OldSceneLoader osl;
    public float scoreToWin = 10;

    public GameObject Crosshair;
    public GameObject Timer;
    public GameObject Score;

    public GameObject BookShooter;
    public GameObject Books;
    public float WinScreenWaitTime;
    public float WinsTimer;

    // Start is called before the first frame update
    void Start()
    {
        Crosshair.SetActive(true);
        Timer.SetActive(true);
        Score.SetActive(true);



    }

    // Update is called once per frame
    void Update()
    {

        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
            WinScreenWaitTime = timeValue;

        }
        else
        {
            timeValue = 0;

            if (timeValue == 0)
            {
                LoadingScreens();
            }
        }
        DisplayTime(timeValue);

    }


    public void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay <= 0)
        {
            timeToDisplay = 0;


        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void DisplayScore(float scoreToDisplay)
    {

        playerScore += scoreToDisplay;
        if (playerScore >= scoreToWin)
        {
            playerScore = scoreToWin;
            LoadingScreens();
        }

        scoreText.text = string.Format("{0:00}", playerScore);
    }
    void LoadingScreens()
    {
        BookShooter.SetActive(false);
        if (timeValue == 0 && playerScore < scoreToWin)
        {


            osl.LoadScene(2);
            return;
        }


        else if (timeValue != 0 && playerScore == scoreToWin)
        {
            sceneloader.LoadScene();

            return;
        }
    }

}

