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
    [Range(0.1f, 1f)]
    public float JumpCheck = .4f;

    [Header("Checks")]
    public GameObject GroundCheck;
    public LayerMask WhatIsGround;

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Animator anim;

    private Vector2 MoveDirection;
    private Vector3 Velocity = Vector3.zero;
    private Vector3 targetVelocity;
    private bool CanJump = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetFloat("Velocity", Mathf.Abs(rb.velocity.x));

        MoveDirection.x = Input.GetAxisRaw("Horizontal");
        MoveDirection.y = Input.GetAxisRaw("Vertical");

        if (Physics2D.OverlapCircle(GroundCheck.transform.position, JumpCheck, WhatIsGround))
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

        if (rb.velocity.x > 0.1f)
        {
            sr.flipX = true;
        } else
        {
            sr.flipX = false;
        }
    }

    void FixedUpdate()
    {
        targetVelocity = new Vector2(MoveDirection.x * 10f, rb.velocity.y);

        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref Velocity, Smoothing);
    }

    private void Jump()
    {
        rb.AddForce(new Vector2(0,JumpForce), ForceMode2D.Impulse);
    }
}
