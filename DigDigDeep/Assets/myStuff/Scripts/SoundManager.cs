using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static SoundManager singleton;
    [SerializeField] private AudioClip soundClick;
    [SerializeField] private AudioClip soundGrass;
    [SerializeField] private AudioClip soundSand;
    [SerializeField] private AudioClip soundBrick;
    [SerializeField] private AudioClip soundStone;
    [SerializeField] private AudioClip soundGems;
    [SerializeField] private AudioClip soundEnd;

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

    //Declaring what audioSource is
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    //These are the methods used to play each sound effect
    public void PlayClickSound()
    {
        audioSource.PlayOneShot(soundClick);
    }
    public void PlayGrassSound()
    {
        audioSource.PlayOneShot(soundGrass);
    }
    public void PlaySandSound()
    {
        audioSource.PlayOneShot(soundSand);
    }
    public void PlayBrickSound()
    {
        audioSource.PlayOneShot(soundBrick);
    }
    public void PlayStoneSound()
    {
        audioSource.PlayOneShot(soundStone);
    }
    public void PlayGemsSound()
    {
        audioSource.PlayOneShot(soundGems);
    }
    public void PlayEndSound()
    {
        audioSource.PlayOneShot(soundEnd);
    }
}
