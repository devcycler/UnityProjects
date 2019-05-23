using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour
{
    public GameObject thisBodyPart;
    private Rigidbody2D bodypartRB;
    private float BP_speedX;
    private float BP_speedY;
    private float BP_speedZ;
    private ParticleSystem blood;
    private Rigidbody2D tempRB;






    // Start is called before the first frame update
    void Start()
    {
        blood = thisBodyPart.GetComponent<ParticleSystem>();
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Blade")
        {
            Debug.Log("COLLIDED WITH " + col);
            NEW_Dismember();
            transform.SetParent(null);
            ScoreManager.singleton.IncreaseScore(1);
        }
    }


    void NEW_Dismember()
    {
        Debug.Log("NEWDISMEMBER GameObject Reference is "+ gameObject);
        bodypartRB = gameObject.AddComponent<Rigidbody2D>();
        BP_speedX = (Random.Range(-20, 20));
        BP_speedY = (Random.Range(0, 10)) * 3;
        BP_speedZ = (Random.Range(-20, 90)) * 200;
        bodypartRB.AddForce(new Vector3(BP_speedX, BP_speedY, BP_speedZ));
        blood.Play();
        if (bodypartRB != null)
        {
            bodypartRB.AddForce(new Vector3(BP_speedX, BP_speedY, BP_speedZ));
            //bodypartRB.GetComponent<Rigidbody2D>().AddForce(new Vector3(BP_speedX, BP_speedY, BP_speedZ));
        }
    }
}
