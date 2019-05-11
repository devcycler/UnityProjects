using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbowController : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&& !isFired)
        {
            Fire();
            StartCoroutine(WaitToFire());
        }
        else
        {
            anim.SetBool("isFired", false);
        }
    }

    void Fire()
    {
        anim.SetBool("isFired", true);
    }


    void Reload()
    {
        anim.SetBool("isReloading", true);
    }



    IEnumerator WaitToFire()
    {
        yield return new WaitForSeconds(_reloadTime);
        Reload();

    }
}
