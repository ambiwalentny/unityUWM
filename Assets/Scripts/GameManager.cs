using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball; public PlayerPaddle playerPaddle; public ComputerPaddle computerPaddle; public Player2 player2Paddle;
    public Text playerScoreText; public Text computerScoreText; public Text player2ScoreText;
    private int playerScore; private int computerScore; private int player2Score;
    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();

        ResetRound();
    }
    public void ComputerScores()
    {
        computerScore++;
        computerScoreText.text = computerScore.ToString();
        
        ResetRound();
    }

    public void Player2Scores()
    {
        player2Score++;
        player2ScoreText.text = player2Score.ToString();
        
        ResetRound();
    }

    private void ResetRound()
    {
        playerPaddle.ResetAfterPointPlayer();
        playerScore = 0; playerScoreText.text = playerScore.ToString();
        if (computerPaddle != null)
        {computerPaddle.ResetAfterPointComputer(); computerScoreText.text = computerScore.ToString();}
        if (player2Paddle != null)
        {player2Paddle.ResetAfterPointPlayer2(); player2ScoreText.text = player2Score.ToString();}
        
        ball.ResetAfterPointBall();
        ball.AddStartingForce();
    }
    public void ResetGame()
    {   
        playerScore = 0;
        if(computerPaddle != null)
        { computerScore = 0;}
        if (player2Paddle != null)
        {player2Score = 0;}
        ResetRound();
        
        
    }
}
