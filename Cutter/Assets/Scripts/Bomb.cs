using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public Rigidbody2D bombRef;
    public GameObject explosion;
    private float speedX;
    private float speedY;
    private float speedZ = 0f;
    private float BP_speedX;
    private float BP_speedY;
    private float BP_speedZ;

    void Start()
    {
        bombRef = gameObject.GetComponent<Rigidbody2D>();
        Launch();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            Explode();
        }
    }
    void CheckSpeed(float x, float y, float z)
    {
        if (transform.position.x < 0)
        {
            speedX = Random.Range(0, 6);
        }
        else
        {
            speedX = Random.Range(-6, 0);
        }
        speedY = Random.Range(11, 16);
        speedZ = 0f;
    }

    void Launch()
    {
        //Debug.Log("BOMB: Launch Achieved");
        CheckSpeed(speedX, speedY, speedZ);
        bombRef.GetComponent<Rigidbody2D>().AddForce(new Vector2(speedX, speedY), ForceMode2D.Impulse);
        float zSpin = Random.Range(0, 360);
        transform.rotation = Quaternion.Euler(0f, 0f, zSpin * 90);
    }
    void Explode()
    {
        GameObject ex = Instantiate(explosion, bombRef.transform.position, Quaternion.identity) as GameObject;
        SoundManager.singleton.Sound_RandomExp();
        Destroy(gameObject);
    }

        void Update()
    {
        if (gameObject.transform.position.y < -50)
        {
            Debug.Log("Bomb Removed, -Y position exceeded!");
            Destroy(gameObject);
        }
        if (gameObject.transform.position.x < -10)
        {
            Debug.Log("Bomb Removed, -X position exceeded!");
            Destroy(gameObject);
        }
        if (gameObject.transform.position.x > 10)
        {
            Debug.Log("Bomb Removed, +X position exceeded!");
            Destroy(gameObject);
        }
    }
}
