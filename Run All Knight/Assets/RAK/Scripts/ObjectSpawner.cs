using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public float arrowSpeed = 0f;
    public GameObject arrow;
    public GameObject[] obstacleList;
    private Vector3 pos;

    void Start()
    {
        pos = this.transform.position;
        Invoke("SpawnArrow", (Random.Range(0f, 3f)));
        Invoke("SpawnObstacle", (Random.Range(3f, 5f)));
    }

    private void SpawnArrow()
    {
        float delay = Random.Range(1f, 2f);
        float xPos = Random.Range(-3f, 3f);
        Instantiate(arrow, new Vector3(xPos, transform.position.y, transform.position.z), Quaternion.identity);
        Invoke("SpawnArrow", delay);
    }

    private void SpawnObstacle()
    {
        float delay = Random.Range(3f, 10f);
        float xPos = Random.Range(-3f, 3f);
        int obstacleNumber = Random.Range(0, obstacleList.Length);
        Instantiate(obstacleList[obstacleNumber],new Vector3 (xPos, 0f,transform.position.z), Quaternion.identity);
        Invoke("SpawnObstacle", delay);
    }

    private void SpawnSwordPickUp()
    {
        //code for sword drops here
    }


}
