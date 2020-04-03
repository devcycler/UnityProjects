using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Core : MonoBehaviour
{
    private float lifetime = 20f;
    private float fSpeed;
    public GameObject blood;
    void Awake()
    {
        Destroy(this, lifetime);
    }

    void Update()
    {
        fSpeed = (LevelManager.Instance.PlatformSpeed * 3);
        transform.position = transform.position + fSpeed * transform.forward;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<Animator>().SetTrigger("HitByArrow");
            Destroy(gameObject);
            LevelManager.Instance.PlatformSpeed = 0f;
            Instantiate(blood,transform.position, Quaternion.identity);
            Debug.Log("Player was hit!");
        }
    }
}
