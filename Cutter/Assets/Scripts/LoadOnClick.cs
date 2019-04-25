using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour
{
    public void MainMenuScreen()
    {
        //SoundManager.singleton.PlayClickSound();
        SceneManager.LoadScene(0);
    }
    public void StartGame()
    {
        //SoundManager.singleton.PlayClickSound();
        SceneManager.LoadScene(1);
    }
}
