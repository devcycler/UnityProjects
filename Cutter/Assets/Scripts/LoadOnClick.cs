using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class LoadOnClick : MonoBehaviour
{
    public void MainMenuScreen()
    {
        Debug.Log("Time to Show ads? = " + GameOverManager.singleton.timeToShowAds);
        if (GameOverManager.singleton.timeToShowAds)
        {
            //Advertisement.Show();
            //Need to research what the fix for this was
        }
        SoundManager.singleton.Sound_ButtonClick();
        SceneManager.LoadScene(0);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        SoundManager.singleton.Sound_ButtonClick();
    }
}
