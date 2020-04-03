using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterWheelRotation : MonoBehaviour
{
    public float speed = -0.3f;
    void Update()
    {
        transform.Rotate(speed, 0, 0);
    }
}
