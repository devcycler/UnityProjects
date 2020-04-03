using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodCore : MonoBehaviour
{
    private float lifetime = 5.5f;
    void Awake()
    {
        Destroy(this, lifetime);
    }
}
