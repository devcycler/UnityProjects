using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour
{
    public Rigidbody2D bombRef;
    public GameObject explosion;
    public Text timeText;
    private float speedX;
    private float speedY;
    private float speedZ = 0f;
    private float BP_speedX;
    private float BP_speedY;
    private float BP_speedZ;
    private int currentTime;

    void Start()
    {
        bombRef = gameObject.GetComponent<Rigidbody2D>();
        Launch();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            LosePoints();
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


    //******************************
    //Need to research a way to take away time when you hit bombs instead of losing points
    //******************************

    private void LosePoints()
    {
        ScoreManager.singleton.IncreaseScore(-3);
    }

    private void IsOffScreen()
    {
        if (gameObject.transform.position.y < -20)
        {
            //Debug.Log("Bomb Removed, -Y position exceeded!");
            Destroy(gameObject);
        }
        if (gameObject.transform.position.x < -10)
        {
            //Debug.Log("Bomb Removed, -X position exceeded!");
            Destroy(gameObject);
        }
        if (gameObject.transform.position.x > 10)
        {
            //Debug.Log("Bomb Removed, +X position exceeded!");
            Destroy(gameObject);
        }
    }


    void Update()
    {
        IsOffScreen();
    }
}
