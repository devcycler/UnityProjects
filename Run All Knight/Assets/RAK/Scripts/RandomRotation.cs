using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour
{
    private float rotationAngle;
    // Start is called before the first frame update
    void Start()
    {
        rotationAngle = Random.Range(0f, 359f);
        this.transform.Rotate(0f, rotationAngle, 0f);
    }
}
