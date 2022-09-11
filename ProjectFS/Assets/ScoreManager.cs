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
}
