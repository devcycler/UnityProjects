using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnightMovement : MonoBehaviour
{
    public GameObject Target;
    public Slider SliderDis;
    private Vector3 newPos;

    public void MovePlayer()
    {
        Vector3 currentpos = transform.position;
        newPos =  new Vector3(SliderDis.value,transform.position.y, 0.0f);
        newPos.x = Mathf.Clamp(SliderDis.value, -3.5f, 3.5f);
        transform.position = Vector3.Lerp(currentpos, newPos, 5f);
    }
}
