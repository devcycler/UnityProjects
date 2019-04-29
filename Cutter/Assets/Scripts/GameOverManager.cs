using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class GameOverManager : MonoBehaviour
{
    public static GameOverManager singleton;
    public float GameCounter { get; set; }
    public bool GameIsOver;
    public bool timeToShowAds = false;
    private float restartTimer;
    private float timeTF;
    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();

        if (singleton == null)
        {
            singleton = this;
        }
        else if (singleton != this)
        {
            Destroy(gameObject);
        }
    }

    public void GameOver(float _timer)
    {
        timeTF = _timer;
        if (timeTF < 1)
        {
            Debug.Log("GAME OVER MANAGER: GAME OVER TRIGGER");
            GameIsOver = true;
            anim.SetTrigger("GameOverTrigger");
            GetGameCounter(1);
        }

    }

    public void GetGameCounter(float valueGiven)
    {
        GameCounter += valueGiven;
        PlayerPrefs.SetFloat("GameCounter",GameCounter);
        float currentGameCounter = PlayerPrefs.GetFloat("GameCounter");
        Debug.Log("GoM: GameCounter = " + currentGameCounter);
        if (currentGameCounter > 2)
        {
            timeToShowAds = true;
        }
    } 

}



//need to adjust game time
//    need to stop sound effects after game is GameOver
//    need to figure out wtf is wrong with the background in landscape mode on the phone
//    once the gameplay loop is finished, need to work on getting the body parts servered
//    then add blood effects and screen splashes