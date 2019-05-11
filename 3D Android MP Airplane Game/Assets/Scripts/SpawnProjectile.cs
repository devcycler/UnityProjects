using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    public GameObject firePointLeft;
    public ParticleSystem leftMuzzleFlash;
    public ParticleSystem rightMuzzleFlash;
    public GameObject firePointRight;
    public GameObject bullet;
    void Start()
    {
        //leftMuzzleFlash = GetComponentInChildren<ParticleSystem>();
        //rightMuzzleFlash = GetComponentInChildren<ParticleSystem>();
    }
    void Update()
    {
        //SpawnBullet();
    }
    void DualMUzzleFlash()
    {
        //leftMuzzleFlash.Play();
        //rightMuzzleFlash.Play();
    }
    public void SpawnBullet()
    {
        if (firePointLeft != null)
        {
            Instantiate(bullet, firePointLeft.transform.position, Quaternion.Euler(0,0f,90f));
        }
        else {
            Debug.Log("FirePointLeft is unassigned in the Editor");
        }
        if (firePointRight != null)
        {
            //DualMUzzleFlash();
            Instantiate(bullet, firePointRight.transform.position, Quaternion.Euler(0,0f, 90f));
        }
        else
        {
            Debug.Log("FirePointRight is unassigned in the Editor");
        }
    }
}
