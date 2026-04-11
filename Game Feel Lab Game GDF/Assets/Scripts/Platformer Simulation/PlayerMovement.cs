using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    public float speed;
    public float jumpForce;

    private Rigidbody rb;
    private float horizontal;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && GroundChecker.Instance.isGrounded)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, rb.velocity.z);
    } 
}
