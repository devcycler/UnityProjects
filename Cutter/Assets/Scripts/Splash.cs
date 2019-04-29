using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour
{
    private Color randomAlpha;
    private float currentAlpha;
    private Vector3 currentPos;
    private Vector3 randomPos;
    private float Pos_X;
    private float Pos_Y;
    private float Rot_z;

    void Start()
    {
        Rot_z = transform.rotation.z;
        randomAlpha = new Color(1, 1, 1, Random.Range(0.3f, 0.5f));
        gameObject.GetComponent<Renderer>().material.color = randomAlpha;
        //InvokeRepeating("ReduceAlpha", 0.3f, 0.3f);
        RandomizeTitleScreenSplashes();
    }
    private void RandomizeTitleScreenSplashes()
    {
        currentPos = transform.position;
        Pos_X = Random.Range(-5, 10);
        Pos_Y = Random.Range(-3, 4);
        Rot_z = Random.Range(0,359);
        randomPos = new Vector3(Pos_X, Pos_Y, 0);
        transform.position = randomPos;
        transform.rotation = Quaternion.Euler(0f, 0f, Rot_z);
    }
    void ReduceAlpha()
    {
        currentAlpha = gameObject.GetComponent<Renderer>().material.color.a;

        if (gameObject.GetComponent<Renderer>().material.color.a <= 0.1f)
        {
            Destroy(gameObject);
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1, currentAlpha - 0.1f);
        }
    }
}