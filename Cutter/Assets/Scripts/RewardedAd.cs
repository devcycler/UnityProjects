using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class RewardedAd : MonoBehaviour
{
    public static bool wasRewarded = false;
    public static bool WasRewarded {
        get
        {
            return wasRewarded;
        }
        set
        {
            wasRewarded = value;
            GameOverManager.loadCount = 0;
            //Debug.Log("RewardedAd: wasRewarded bool = " + wasRewarded);
        }
    }

    /*Clean ad code start
    */
    public void ShowRewardedAd()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show("rewardedVideo", options);
        }
    }
    /*Clean ad code end
    */


    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                WasRewarded = true;
                //Debug.Log("The ad was successfully shown.");
                SceneManager.LoadScene(1);
                break;
            case ShowResult.Skipped:
                //Debug.Log("The ad was skipped before reaching the end.");
                SceneManager.LoadScene(0);
                break;
            case ShowResult.Failed:
                //Debug.LogError("The ad failed to be shown.");
                SceneManager.LoadScene(0);
                break;
        }
    }
}

