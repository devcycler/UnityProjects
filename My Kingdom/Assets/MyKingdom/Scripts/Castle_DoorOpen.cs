using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle_DoorOpen : MonoBehaviour
{
    public Animator _animator;
    [SerializeField] private AudioClip gateOpen;
    [SerializeField] private AudioClip gateClose;
    private AudioSource _audioSource;


    void Start()
    {
        _animator = _animator.GetComponent<Animator>();
        _audioSource = this.GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Guard" || other.tag == "Villager" || other.tag == "Royalty")
        {
            _animator.SetTrigger("Open");
            Sound_Open();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Guard" || other.tag == "Villager" || other.tag == "Royalty")
            {
            _animator.SetTrigger("Close");
            Sound_Close();
        }
    }

    private void Sound_Open()
    {
        _audioSource.PlayOneShot(gateOpen);
    }
    private void Sound_Close()
    {
        _audioSource.PlayOneShot(gateClose);
    }
}
