using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager singleton;

    [SerializeField] private AudioClip buttonClick;
    [SerializeField] private AudioClip[] randomCuts;
    [SerializeField] private AudioClip GameOver;
    [SerializeField] private AudioClip guyThrow;
    [SerializeField] private AudioClip highScore;
    [SerializeField] private AudioClip OutOfTime;
    [SerializeField] private AudioClip AlmostOutOfTime;

    private AudioClip cut;
    private AudioSource audioSource;

    //needs to be only one instance of the singleton, hence this code
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

    //Reference to what audioSource is
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //These are the methods used to play each sound effect
    public void Sound_ButtonClick()
    {
        audioSource.PlayOneShot(buttonClick);
    }
    public void Sound_RandomCut()
    {
        int index = Random.Range(0, randomCuts.Length);
        cut = randomCuts[index];
        audioSource.PlayOneShot(cut);
    }
    public void Sound_GameOver()
    {
        audioSource.PlayOneShot(GameOver);
    }
    public void Sound_Throw()
    {
        audioSource.PlayOneShot(guyThrow);
    }
    public void Sound_HighScore()
    {
        audioSource.PlayOneShot(highScore);
    }
    public void Sound_OutofTime()
    {
        audioSource.PlayOneShot(OutOfTime);
    }
    public void Sound_RunningOutofTime()
    {
        audioSource.PlayOneShot(AlmostOutOfTime);
    }
}
