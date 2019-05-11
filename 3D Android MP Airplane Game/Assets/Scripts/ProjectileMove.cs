using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    private float speed = 150f;
    private float fireRate;
    public float bulletLifeTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, bulletLifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        FireTheGuns();
    }

    public void FireTheGuns()
    {
        if (speed != 0)
        {
            transform.position += transform.forward * (speed * Time.deltaTime);
        }
        else
        {
            Debug.Log("No speed");
        }
    }
}
