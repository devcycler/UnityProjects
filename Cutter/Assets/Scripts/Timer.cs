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
            GameOverManager.singleton.GameOver(float.Parse(timeTF.text));
        }
        timeTF.text = (int.Parse(timeTF.text) - 1).ToString();
        GameOverManager.singleton.GameOver(float.Parse(timeTF.text));
       //Debug.Log(float.Parse(timeTF.text));
    }
}