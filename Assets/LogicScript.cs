using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;
    public TextMeshProUGUI finalScore;

    private static LogicScript _instance;
    public static LogicScript instance
    {
        get {
            if (_instance != null)
            {

                
            }
            return _instance;
        }
       
    }

    private void Awake()
    {
        if (_instance != null)
        {
            Debug.Log("Multiple version");
        }
        _instance = this;
    }

    public void addScore(int scoreToAdd)
    {
        Debug.Log("Score Added");
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        Debug.Log("Game Over");
        gameOverScreen.SetActive(true);
        finalScore.text = scoreText.text;
        scoreText.gameObject.SetActive(false);
        Time.timeScale = 0;
    }
}
