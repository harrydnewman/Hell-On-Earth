using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class ShooterGameTimer : MonoBehaviour
{
    public float timeValue = 30;
    public Text timerText;
    public Text scoreText;
    public float playerScore = 0;
    public float scoreToWin = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);

        
    }

    
    public void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
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
        if (playerScore > scoreToWin)
        {
            playerScore = scoreToWin;
            //gameObject.GetComponent<ShooterPlayerWins>().Tester(endPlayerScore);
        }

        scoreText.text = string.Format("{0:00}", playerScore);
    }




}
