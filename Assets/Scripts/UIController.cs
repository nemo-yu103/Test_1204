using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour
{

    int score = 0;
    GameObject scoreText;
    GameObject gameOverTect;

    public void GameOver()
    {
        this.gameOverTect.GetComponent<Text>().text = "GameOver";
    }

    public void AddScore()
    {
        this.score += 10;
    }

    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverTect = GameObject.Find("GameOver");
    }

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
    }
}