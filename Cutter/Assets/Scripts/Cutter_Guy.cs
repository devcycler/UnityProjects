using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter_Guy : MonoBehaviour
{ 
    public Rigidbody2D cutterGuy;
    private float speedX;
    private float speedY;
    private float speedZ = 0f;
    public GameObject[] bodyPartList;
    private GameObject bodyPart;
    private GameObject hingedBodyPart;
    private HingeJoint2D tempHinge;
    private float BP_speedX;
    private float BP_speedY;
    private float BP_speedZ;

    void Start()
    {
        cutterGuy = gameObject.GetComponent<Rigidbody2D>();
        Launch();
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "Blade")
        {
            //Destroy(gameObject);
            Dismember();
            transform.SetParent(null);
            ScoreManager.singleton.IncreaseScore(1);
        } else
        {
            Destroy(gameObject);
        }
    }
    void CheckSpeed(float x, float y, float z)
    {
        speedX = Random.Range(-2, 6);
        speedY = Random.Range(11, 16);
        speedZ = 0f;
    }

    void Launch()
    {
        //Need to add X checks to make sure Guy is always thrown towards the middle of the screen
        CheckSpeed(speedX, speedY, speedZ);
        cutterGuy.GetComponent<Rigidbody2D>().AddForce(new Vector2(speedX, speedY), ForceMode2D.Impulse);
        float zSpin = Random.Range(0, 360);
        transform.rotation = Quaternion.Euler(0f, 0f, zSpin*50);
    }

    void Dismember()
    {
        int index = Random.Range(0, bodyPartList.Length);
        bodyPart = bodyPartList[index];
        Debug.Log("DISMEMBER: " + bodyPart);
        tempHinge = bodyPart.AddComponent<HingeJoint2D>();
        tempHinge.enabled = false;
        BP_speedX = Random.Range(10, 20);
        BP_speedY = Random.Range(10, 20);
        BP_speedZ = Random.Range(10, 20);
        tempHinge.GetComponent<Rigidbody2D>().AddForce(new Vector3(BP_speedX, BP_speedY, BP_speedZ));
    }

    void Update()
    {
        if (gameObject.transform.position.y < -36)
        {
            Destroy(gameObject);
        }
    }
}
