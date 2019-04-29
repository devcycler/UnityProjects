using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitManager : MonoBehaviour
{
    public static HitManager singleton;
    private SpriteRenderer cutter;
    private SpriteRenderer bodyPart;

    private void Start()
    {
        //cutter = GetComponent<SpriteRenderer>();
        //bodyPart = GetComponentInChildren<SpriteRenderer>(true);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //if (col.tag == "Blade")
        //{
        //    cutter = col.GetComponent<SpriteRenderer>();
        //    Debug.Log("Cutter Part = " + cutter.name);
        //    Debug.Log("Body Part = " + bodyPart);
        //}
    }
}
