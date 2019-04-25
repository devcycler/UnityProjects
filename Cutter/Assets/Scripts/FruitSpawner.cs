using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject appleReference;

    void Start()
    {
        InvokeRepeating("SpawnFruit", 0.5f, 6);
    }

    void SpawnFruit()
    {
        float randomFruit = Random.Range(2, 6);
        //Debug.Log(randomFruit);
        for (byte i = 0; i < randomFruit; i++)
        {
            //Debug.Log("Spawned Fruit");
            GameObject fruit = Instantiate(appleReference, new Vector3(Random.Range(-8, 8),-6,0), Quaternion.identity) as GameObject;
        }
    }
}
