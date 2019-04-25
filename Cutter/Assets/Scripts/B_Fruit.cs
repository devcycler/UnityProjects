using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Fruit : MonoBehaviour
{
    private Rigidbody2D appleRB;
    private float speedX;
    private float speedY;
    private float speedZ = 0f;

    void Start()
    {
        appleRB = gameObject.GetComponent<Rigidbody2D>();
        Launch();
    }

    void CheckSpeed(float x, float y, float z)
    {
        speedX = Random.Range(-2, 6);
        speedY = Random.Range(11, 16);
        speedZ = 0f;
        //Debug.Log(speedX + speedY + speedZ);
    }

    void Launch()
    {
        CheckSpeed(speedX, speedY, speedZ);
        appleRB.GetComponent<Rigidbody2D>().AddForce(new Vector3(speedX, speedY, speedZ), ForceMode2D.Impulse);
        float xSpin = Random.Range(0, 360);
        float ySpin = Random.Range(0, 360);
        transform.rotation = Quaternion.Euler(xSpin, ySpin, 0f);
    }


    void Update()
    {

        /* Remove fruit if out of view */
        if (gameObject.transform.position.y < -36)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            Debug.Log("Brackeys: SLICED!!!");
            Destroy(gameObject);
        }
    }
}
