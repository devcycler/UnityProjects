using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedController : MonoBehaviour
{
    public Slider speedSlider;
    private float speedValue;
    public Text airspeedValue;
    public static SpeedController singleton;
    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }
        else if (singleton != this)
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        airspeedValue.text = speedSlider.value.ToString();
    }
    public float AdjustSpeed()
    {
        return speedSlider.value;
    }
}
