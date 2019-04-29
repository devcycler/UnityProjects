using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject guyReference;
    public GameObject bombReference;
    private float bombTimer;

    void Start()
    {
        InvokeRepeating("SpawnGuy", 0.5f, Random.Range(2,5));
        Invoke("SpawnBomb", RandomBombTimer());
    }

    void SpawnGuy()
    {
        if (!GameOverManager.singleton.GameIsOver == true)
        {
            float randomAmountofGuys = Random.Range(2, 6);
            for (byte i = 0; i < randomAmountofGuys; i++)
            {
                GameObject fruit = Instantiate(guyReference, new Vector3(Random.Range(-8, 8), -6, 0), Quaternion.identity) as GameObject;
                SoundManager.singleton.Sound_Throw();
            }
        }
    }
    public float RandomBombTimer()
    {
        bombTimer = Random.Range(3, 10);
        return bombTimer;
    }
    void SpawnBomb()
    {
        if(!GameOverManager.singleton.GameIsOver == true)
        {

        }
    }
}
