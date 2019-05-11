using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject arrow;
    public Transform shotPoint;
    public float timeBetweenShots;

    private float shotTime;

    private bool isFired = false;
    private bool isReloading;
    [SerializeField] Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis((angle-90), Vector3.forward);
        transform.rotation = rotation;

        Debug.Log("Rotation = " + rotation);
        Debug.Log("Direction = " + direction);


        if (Input.GetMouseButton(0) && !isFired)
            if (Time.time >= shotTime)
            {
                anim.SetBool("isFired", true);
                Instantiate(arrow, shotPoint.position, transform.rotation);
                shotTime = Time.time + timeBetweenShots;
            }
        Reload();
    }

    void Reload()
    {
        anim.SetBool("isReloading", true);
    }
}
