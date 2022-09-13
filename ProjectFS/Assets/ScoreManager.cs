using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalScoreText;
    public float finalTime;

    private void Awake()
    {
        instance = this;
    }
    public void AddScore(int Score)
    {

        score += Score;
        Debug.Log("Mendapatkan skor sebesar " + score);
        scoreText.text = score.ToString();
    }

    public void countFinalScore()
    {
        finalTime =Timer.instance.timer;
        if(finalTime > 0 && finalTime < 60)
        {
            AddScore(500);
        }
        else if (finalTime > 60 && finalTime <120)
        {
            AddScore(400);
        }
        else if (finalTime > 120 && finalTime < 180)
        {
            AddScore(300);
        }
        else if (finalTime > 180 && finalTime < 240)
        {
            AddScore(200);
        }
        else if (finalTime > 240 && finalTime < 3600)
        {
            AddScore(100);
        }
        else if (finalTime > 3600)
        {
            AddScore(0);
        }

        finalScoreText.text = score.ToString();

    }
}
