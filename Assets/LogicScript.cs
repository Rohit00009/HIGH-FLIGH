using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public GameObject pipeSpawner;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        // give text 
        scoreText.text = playerScore.ToString();
        setHighSCore(playerScore);
        
    }

    public void setHighSCore( int plyerScore = 0)
    {
        if (playerScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
        }
        scoreText.text = playerScore.ToString();
        highScoreText.text = $"HighScore : {PlayerPrefs.GetInt("HighScore", 0).ToString()}";
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        Destroy(pipeSpawner);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
