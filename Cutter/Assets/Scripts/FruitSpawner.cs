using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject guyReference;

    void Start()
    {
        InvokeRepeating("SpawnGuy", 0.5f, Random.Range(2,5));
    }

    void SpawnGuy()
    {
        if (!GameOverManager.singleton.GameIsOver == true)
        {
            float randomAmountofGuys = Random.Range(1, 3);
            for (byte i = 0; i < randomAmountofGuys; i++)
            {
                GameObject fruit = Instantiate(guyReference, new Vector3(Random.Range(-8, 8), -6, 0), Quaternion.identity) as GameObject;
                SoundManager.singleton.Sound_Throw();
            }
        }
    }
}
