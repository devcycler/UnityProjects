using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{

    public Text timeTF; 
    public static Timer singleton;

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

    void Start()
    {
        if (RewardedAd.WasRewarded)
        {
            timeTF.text = (int.Parse(timeTF.text) + 20).ToString();
        }
        InvokeRepeating("ReduceTime", 1, 1);
    }

    void ReduceTime()
    {
        if (timeTF.text == "4")
        {
            SoundManager.singleton.Sound_RunningOutofTime();
        }
        if (timeTF.text == "1")
        {
            SoundManager.singleton.Sound_OutofTime();
        }
        if (timeTF.text == "0")
        {
            GameOverManager.singleton.GameOver();
        }
        if (timeTF.text == "-1")
        {
            timeTF.text = "0";
        }
        timeTF.text = (int.Parse(timeTF.text) - 1).ToString();
    }
}
