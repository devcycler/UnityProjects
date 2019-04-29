using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    public GameObject bladeTrailPrefab;
    public float minCuttingVelocity = 0.001f;
    GameObject currentBladeTrail;
    private bool isCutting;
    Rigidbody2D rb;
    Camera cam;
    CircleCollider2D circleCollider;
    Vector2 previousPosition;

    private void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }
    void Update()
    {
        if (!GameOverManager.singleton.GameIsOver == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                {
                    SoundManager.singleton.Sound_RandomCut();
                    StartCutting();
                }

            }
            else if (Input.GetMouseButtonUp(0))
            {
                StopCutting();
            }

            if (isCutting)
            {
                UpdateCut();
            }
        }
    }

    void StartCutting()
    {
        isCutting = true;
        currentBladeTrail = Instantiate(bladeTrailPrefab, transform);
        previousPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        circleCollider.enabled = false;
    }

    void StopCutting()
    {
        isCutting = false;
        currentBladeTrail.transform.SetParent(null);
        circleCollider.enabled = false;
        Destroy(currentBladeTrail, 2f);
    }

    void UpdateCut()
    {
        Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;
        float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;
        if (velocity > minCuttingVelocity)
        {
            circleCollider.enabled = true;
        } else
        {
            circleCollider.enabled = false;
        }

        previousPosition = newPosition;     //Updates the position
    }
}
