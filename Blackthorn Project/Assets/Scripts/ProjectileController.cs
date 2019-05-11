using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public float arrowSpeed;
    public float arrowLifeTime;

    public GameObject explosion;

    private void Start()
    {
        Invoke("DestroyProjectile", arrowLifeTime);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * arrowSpeed * Time.deltaTime);//vector2.up means forward!
    }
    void DestroyProjectile()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
