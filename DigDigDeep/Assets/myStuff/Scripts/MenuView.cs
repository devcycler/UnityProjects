using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuView : MonoBehaviour
{
    [SerializeField] private Text totalBlocksDestroyed;
    [SerializeField] private Text totalBlocksMissed;

    private int blocksDestroyed;
    private int blocksMissed;


    // Start is called before the first frame update
    void Start()
    {
        blocksDestroyed = PlayerPrefs.HasKey("TotalBlocksDestroyed") ? PlayerPrefs.GetInt("TotalBlocksDestroyed") : 0;
        blocksMissed = PlayerPrefs.HasKey("TotalBlocksMissed") ? PlayerPrefs.GetInt("TotalBlocksMissed") : 0;
        //If player has variable, get it else(:) set it to 0

        totalBlocksDestroyed.text = "Total Blocks Destroyed <color=green>" + "\n" + blocksDestroyed + "</color>" + "\n";
        totalBlocksMissed.text = "Total Blocks Missed <color=red>" + "\n" + blocksMissed + "</color>";
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }
}
