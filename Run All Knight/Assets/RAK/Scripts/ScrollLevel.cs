using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollLevel : MonoBehaviour
{
    public float speed;

    void Update()
    {
        float speed = LevelManager.Instance.PlatformSpeed;
        MovePlatform(speed);
    }

    public void MovePlatform(float _speed)
    {
        this.transform.position += KnightController.player.transform.forward * _speed;
        //if (transform.position.z < -160)
        //{
        //    Destroy(gameObject);
        //}
        //Need a better way to handle the removal of platforms!
    }
}
