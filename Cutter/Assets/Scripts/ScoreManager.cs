using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager singleton;
    public int Score { get; set; }
    [SerializeField] private Text scoreText;

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
        if (Score < 0)
        {
            Score = 0;
        }
        //Debug.Log("Score = " + Score);
        PlayerPrefs.SetInt("Score", Score);
    }

    
    // Update is called once per frame
    void Update()
    {
        scoreText.text = Score.ToString();
    }
}
