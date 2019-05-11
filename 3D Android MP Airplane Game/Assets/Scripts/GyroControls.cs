using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControls : MonoBehaviour
{

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion deviceRotation = DeviceRotation.Get();
        rb.transform.rotation = deviceRotation;
        Debug.Log(deviceRotation + "\n" + rb);
    }
}
