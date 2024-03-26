using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PongGameManager : MonoBehaviour
{
    public PongBall ball;
    public Text playerScoreText;
    public Text computerScoreText;
    public PongPaddle playerPaddle;
    public PongPaddle computerPaddle;
    public SceneLoader sceneloader;
    public OldSceneLoader osl;
    private int playerScore;
    private int computerScore;

    public void PlayerScores()
    {
        playerScore++;
        this.playerScoreText.text = playerScore.ToString();
        if (playerScore == 5)
        {
            sceneloader.LoadScene();
        }
        ResetRound();
    }
    public void ComputerScores()
    {
        computerScore++;
        this.computerScoreText.text = computerScore.ToString();
        if (computerScore == 5)
        {
            osl.LoadScene(4);
        }
        ResetRound();
    }
    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
