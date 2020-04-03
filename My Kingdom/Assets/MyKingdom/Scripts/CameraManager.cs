using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager singleton;
    //public Transform throneMenuCameraAngle = null;
    public GameObject throneMenuParent;
    public Camera mainCamera;
    public Camera throneCamera;


    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }
        else if (singleton != this)
        {
            //Destroy(gameObject);
        }
    }

    private void Start()
    {
        throneMenuParent = GameObject.FindGameObjectWithTag("ThroneMenuCam");
        //throneCamera = gameObject.GetComponentInChildren<Camera>();
        //Debug.Log(throneCamera);
    }


    public void CameraActivate()
    {
        mainCamera.enabled = false;
        throneCamera.enabled = true;
        Debug.Log("Throne Menu Camera Activated Method");
    }

    public void CameraDeactivate()
    {
        mainCamera.enabled = true;
        throneCamera.enabled = false;
        Debug.Log("Throne Menu Camera Deactivated Method");
    }
}
