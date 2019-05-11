using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveAmount;
    //private Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
    }

    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));          //(x,y)
        moveAmount = moveInput.normalized * speed;                                                              //makes sure the player doesn't move faster when going diagonally
        //Debug.Log(moveAmount);

        //if (moveInput != Vector2.zero)
        //{
        //    anim.SetBool("isRunning", true);
        //}
        //else
        //{
        //    anim.SetBool("isRunning", false);
        //}
    }

    private void FixedUpdate()                                                                                  //Anything with physics should be handled here in the FixedUpdate
    {
        rb.MovePosition(rb.position + moveAmount * Time.fixedDeltaTime);                                        //makes sure player moves at the same speed regardless of FPS
    }
}
