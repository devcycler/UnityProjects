using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter_Guy : MonoBehaviour
{ 
    public Rigidbody2D cutterGuy;
    private float speedX;
    private float speedY;
    private float speedZ = 0f;
    private float BP_speedX;
    private float BP_speedY;
    private float BP_speedZ;

    void Start()
    {
        cutterGuy = gameObject.GetComponent<Rigidbody2D>();
        Launch();
    }


    void CheckSpeed(float x, float y, float z)
    {
        speedX = Random.Range(-2, 6);
        speedY = Random.Range(11, 16);
        speedZ = 0f;
    }

    void Launch()
    {
        CheckSpeed(speedX, speedY, speedZ);
        cutterGuy.GetComponent<Rigidbody2D>().AddForce(new Vector2(speedX, speedY), ForceMode2D.Impulse);
        float zSpin = Random.Range(0, 360);
        transform.rotation = Quaternion.Euler(0f, 0f, zSpin);
    }

    void Update()
    {
        if (gameObject.transform.position.y < -12)
        {
            Destroy(gameObject);
        }
    }
}
