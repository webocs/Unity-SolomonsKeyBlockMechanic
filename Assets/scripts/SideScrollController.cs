using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScrollController : MonoBehaviour {

    Animator animator;
    Rigidbody2D rb;
    public float walkSpeed;
    public float jumpPower;

    bool grounded;
 
    public Transform groundCheck;
    public float groundRadius;
    public LayerMask whatIsGround;


	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        grounded = Physics2D.OverlapCircle(groundCheck.position,groundRadius,whatIsGround);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetTrigger("walkingLeft");
            rb.AddForce(Vector2.left*walkSpeed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetTrigger("walkingRight");
            rb.AddForce(Vector2.right* walkSpeed);
        }

        else
        {
            animator.SetTrigger("idle");
            rb.isKinematic = true;
            rb.isKinematic = false;
        }
     
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {           
            rb.AddForce(Vector2.up * jumpPower);
        }

    }

  
}
