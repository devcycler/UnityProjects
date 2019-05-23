using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class LoadOnClick : MonoBehaviour
{
    public void MainMenu()
    {
        SoundManager.singleton.Sound_ButtonClick();
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        SoundManager.singleton.Sound_ButtonClick();
        SceneManager.LoadScene(1);
    }

    public void PlayAgain()
    {
        SoundManager.singleton.Sound_ButtonClick();
        SceneManager.LoadScene(1);
    }
}
