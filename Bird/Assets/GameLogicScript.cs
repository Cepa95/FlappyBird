using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOver;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void restartFlappy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameFinished()
    {
        gameOver.SetActive(true);
    }

}
