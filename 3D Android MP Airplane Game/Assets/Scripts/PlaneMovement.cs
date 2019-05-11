using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneMovement : MonoBehaviour
{
    public Rigidbody planeRB;
    public Slider speedSlider;
    private float planeSpeed;
    private float speedValue;

    private void Start()
    {
        planeRB = GetComponent<Rigidbody>();
    }
    void Update()
    {
        planeRB.transform.position += Vector3.forward * Time.deltaTime * speedSlider.value;
    }
}


//Need to adjust speed, timing on throttle and make throttle slightly bigger (20%)
//Need a level off button to fix any "issues"
//Need a fire button or 2 (1 for rockets?)
//Health bar in the top corner (left or right)
//Kill counter
//
