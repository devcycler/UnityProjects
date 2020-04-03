using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    private float maxSpeed;
    public float speed;
    private float startSpeed;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;   
        } else if (Instance != this)
        {
            Destroy(gameObject);
        }
        maxSpeed = -0.15f;
        startSpeed = -0.15f;
        speed = startSpeed;
    }

    
    public float PlatformSpeed {
        get
        {
            return speed;
        }
        set
        { 
            speed = value;
            if (speed > 0)
            {
                speed = speed * -1;//Needs to always return a negative value to keep the platforms moving the correct way
            }
            if (speed < maxSpeed)
            {
                speed = maxSpeed;
            }
            Debug.Log("PlatformSpeed changed to: " + value);
        }
    }
}
