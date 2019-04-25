using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeTF;
    public Text gameOverText;
    public Color gameOverColor;
    private Animator anim;
    private float gameOverAlpha = 1f;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = gameOverText.GetComponent<Animator>();
        InvokeRepeating("ReduceTime", 1, 1);
    }

    void ReduceTime()
    {
        if (timeTF.text == "1")
        {
            Time.timeScale = 0;
            gameOverText.GetComponent<Text>().color = new Color(gameOverColor.r, gameOverColor.g, gameOverColor.b, gameOverAlpha);
            GameManager.singleton.GameOver();
        }
        timeTF.text = (int.Parse(timeTF.text) - 1).ToString();
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}


//Need to work on Game Over text animation but that can wait til later
//Need to implement thrower script, maybe on a new empty GO?
//Need to add touch controls to destroy "apples"
//Still haven't found a way to "cut" a game object into pieces...need more research!