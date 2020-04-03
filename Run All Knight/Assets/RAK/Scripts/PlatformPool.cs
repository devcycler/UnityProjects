using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPool : MonoBehaviour
{
      [System.Serializable]
      public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public List<Pool> pools;
    public Dictionary<string, Queue<GameObject>> platformDictionary;

    #region Singleton
    public static PlatformPool Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion
    void Start()
    {
        platformDictionary = new Dictionary<string, Queue<GameObject>>();
        foreach (Pool pool in pools)
        {
            Queue<GameObject> platformPool = new Queue<GameObject>();
            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                platformPool.Enqueue(obj);
            }
            platformDictionary.Add(pool.tag, platformPool);
        }
    }

    public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    {
        if (!platformDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool with tag " + tag + "doesn't exist.");
            return null;
        }
        GameObject platform = platformDictionary[tag].Dequeue();
        platform.SetActive(true);
        platform.transform.position = position;
        platform.transform.rotation = rotation;

        platformDictionary[tag].Enqueue(platform);

        return platform;
    }
}
