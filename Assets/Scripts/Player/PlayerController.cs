﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Vector3 _startPos;

    [SerializeField]
    private float downForce;
    private bool isDead = false;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        transform.position = _startPos;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PushDown();
        }
    }

    // Actions

    void PushDown()
	{
        // When input tap push object down
        //...zero out the birds current y velocity before...
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0, -downForce));
    }

    void Die()
	{
        // When collide with obstacle kill player
        isDead = true;
	}

}