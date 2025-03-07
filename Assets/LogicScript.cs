using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public Text text;
    private int score;
    public GameObject gameOverScreen;
    public Text scoreText;

    public void UpdateScore(int val)
    {
        score += val;
        if (score > 50) {
            
        }

        text.text = score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        scoreText.text = score.ToString();
        gameOverScreen.SetActive(true);
    }
}
