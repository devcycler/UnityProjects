using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class GameOverManager : MonoBehaviour
{
    public static GameOverManager singleton;
    public static int loadCount = 0;
    public bool GameIsOver;
    public bool timeToShowAds = false;
    public Animator anim;
    
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
    private void Start()
    {
        //Time.timeScale = 0.6f;
    }
    public void GameOver()
    {
        GameIsOver = true;
        anim.SetTrigger("GameOverTrigger");
        loadCount++;
    }

    public void GameOverBackToMain()
    {
        SoundManager.singleton.Sound_ButtonClick();
        //Debug.Log("GOM LoadCount = " + loadCount);
        if (loadCount > 2)
        {
            loadCount = 0;
            Advertisement.Show();
            SceneManager.LoadScene(0);
        }
        SceneManager.LoadScene(0);
    }
}