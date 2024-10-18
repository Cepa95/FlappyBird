using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

}
