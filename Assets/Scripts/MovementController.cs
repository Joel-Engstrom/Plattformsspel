using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [Header("Variabler")]
    public float MoveSpeed = 5f;
    public int JumpForce = 100;
    [Range(0f, 0.5f)]
    public float Smoothing = .3f;

    [Header("Checks")]
    public GameObject GroundCheck;
    public LayerMask WhatIsGround;

    private Rigidbody2D rb;

    private Vector2 MoveDirection;
    private Vector3 Velocity = Vector3.zero;
    private bool CanJump = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MoveDirection.x = Input.GetAxisRaw("Horizontal");
        MoveDirection.y = Input.GetAxisRaw("Vertical");

        if (Physics2D.OverlapCircle(GroundCheck.transform.position, 0.2f, WhatIsGround))
        {
            CanJump = true;
        } else
        {
            CanJump = false;
        }

        if (Input.GetButtonDown("Jump") && CanJump)
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        Vector3 targetVelocity = new Vector2(MoveDirection.x * 10f, rb.velocity.y);

        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref Velocity, Smoothing);
    }

    private void Jump()
    {
        rb.AddForce(new Vector2(0,JumpForce), ForceMode2D.Impulse);
    }
}
