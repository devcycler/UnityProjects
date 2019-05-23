using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager singleton;
    public int Score { get; set; }
    [SerializeField] private Text scoreText;
    [SerializeField] private Text endGameText;

    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }
        else if (singleton != this)
        {
            Destroy(gameObject);
        }
    }

    //Increase Score
    public void IncreaseScore(int valueToAdd)
    {
        Score += valueToAdd;
        int highScore = PlayerPrefs.GetInt("HighScore");
        if (Score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", Score);
        }
        PlayerPrefs.SetInt("Score", Score);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Score.ToString();
        endGameText.text = Score.ToString();
    }
}
