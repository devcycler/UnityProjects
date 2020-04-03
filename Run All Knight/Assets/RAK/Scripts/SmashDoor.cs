using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashDoor : MonoBehaviour
{
    public GameObject leftDoor;
    public GameObject rightDoor;
    public ParticleSystem doorExplosion;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Door Triggered");
        if(other.tag == "Player")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("HitByArrow");
        }
        if(other.tag == "SwordProjectile")
        {
            doorExplosion.Play();
            leftDoor.SetActive(false);
            rightDoor.SetActive(false);
        }

    }
}
