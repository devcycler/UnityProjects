using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : MonoBehaviour
{
    [SerializeField] private Text highScoreText;

    private int highScore;
    private int lastScore;
    void Start()
    {
        highScore = PlayerPrefs.HasKey("HighScore") ? PlayerPrefs.GetInt("HighScore") : 0;
        if (ScoreManager.singleton.Score > highScore)
        {
            highScore = ScoreManager.singleton.Score;
        }
        highScoreText.text = "BEST: <color=white>" + highScore + "</color>";
    }
}

