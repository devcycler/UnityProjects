using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class GameOverManager : MonoBehaviour
{
    public static GameOverManager singleton;
    static int loadCount = 0;
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

    public void GameOver()
    {

        GameIsOver = true;
        anim.SetTrigger("GameOverTrigger");
        loadCount++;
        Debug.Log(loadCount);
        if (loadCount > 2)
        {
            timeToShowAds = true;
            loadCount = 0;
            Debug.Log("LoadCount Reset! Now = ");
            Debug.Log(loadCount);
        }
    }
}



//need to adjust game time
//    need to stop sound effects after game is GameOver
//    need to figure out wtf is wrong with the background in landscape mode on the phone
//    once the gameplay loop is finished, need to work on getting the body parts servered
//    then add blood effects and screen splashes