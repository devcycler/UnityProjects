using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    // Update is called once per frame
    void Update()
    {

        if (GameManager.singleton.GameEnded)
        {
            scoreText.text = "<color=red> CAVE IN!! </color>";
        }
        else
        {
            scoreText.text = GameManager.singleton.Score.ToString();
        }
    }
}
