using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public Rigidbody2D bomb;
    private float speedX;
    private float speedY;

    private void Start()
    {
        bomb = gameObject.GetComponent<Rigidbody2D>();
        ThrowBomb();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Blade")
        {
            Explode();
            Destroy(gameObject);
        }
    }
    void CheckSpeed(float x, float y, float z)
    {
        speedX = Random.Range(-2, 6);
        speedY = Random.Range(11, 16);
    }
    private void ThrowBomb()
    {
        CheckSpeed(speedX, speedY, 0f);
        bomb.GetComponent<Rigidbody2D>().AddForce(new Vector2(speedX, speedY), ForceMode2D.Impulse);
        float zSpin = Random.Range(0, 360);
        transform.rotation = Quaternion.Euler(0f, 0f, zSpin * 50);
    }

    private void Explode()
    {
        Debug.Log("BOOM!");
    }

}





