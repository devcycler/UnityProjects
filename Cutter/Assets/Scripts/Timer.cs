using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeTF;
    private Animator anim;

    void Start()
    {
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
            Debug.Log("TIMER SCRIPT: GameOver");
        }
        timeTF.text = (int.Parse(timeTF.text) - 1).ToString();
        
    }
}