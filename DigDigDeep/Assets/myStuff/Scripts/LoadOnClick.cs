using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour
{
    public void LoadScene(int level)
    {
        //SoundManager.singleton.PlayClickSound();
        SceneManager.LoadScene(level);
    }
    public void LevelSelectionScreen()
    {
        //SoundManager.singleton.PlayClickSound();
        SceneManager.LoadScene(1);
    }

    public void MainMenuScreen()
    {
        //SoundManager.singleton.PlayClickSound();
        SceneManager.LoadScene(0);
    }

    public void RandomizedLevelSelector()
    {
        //SoundManager.singleton.PlayClickSound();
        int randomLevel = Random.Range(3, 9);
        SceneManager.LoadScene(randomLevel);
    }
}
