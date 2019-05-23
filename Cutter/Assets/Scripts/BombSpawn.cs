using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomArrayExtensions;

public class BombSpawn : MonoBehaviour
{
    public GameObject bomb;
    public Vector3[] bombSpawnList;

    private void Start()
    {
        InvokeRepeating("SpawnBomb", 1f, Random.Range(5, 8));
    }

    void SpawnBomb()
    {
        Vector3 selectedSpawnPoint = bombSpawnList.GetRandom();
        if(!GameOverManager.singleton.GameIsOver == true)
        {
            GameObject b = Instantiate(bomb, selectedSpawnPoint, Quaternion.identity) as GameObject;
        }
    }
}





