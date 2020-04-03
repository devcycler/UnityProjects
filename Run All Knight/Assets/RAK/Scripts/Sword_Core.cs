using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_Core : MonoBehaviour
{
    public ParticleSystem swordBoom;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            swordBoom.Play();
        }
    }
}
