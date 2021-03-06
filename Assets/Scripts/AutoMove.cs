﻿//////////////////////
///Name: Andrew Dahlman-Oeth
///Date: 11/5/2020
///Description: Move the GameObject left/right or up/down
//////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    [Tooltip("Speed at which the GameObject moves")]
    public float MoveSpeed = 5.0f;
    [Tooltip("How far the object moves from its' origin")]
    public float MoveLength = 1.0f;
    [Tooltip("For left/right movement set to true, for up/down movement set to false")]
    public bool Direction = true;
    [Tooltip("True for right, false for left")]
    public bool LeftOrRight = true;
    private Vector3 StartPos;
    private int direction = 1;
    Vector3 movement;
    Vector3 StartPosition;

    Rigidbody2D myRB;

    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        StartPos = transform.position;
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Direction)
        {
            if(transform.position.x > StartPos.x + MoveLength)
            {
                direction = -1;
            }
            else if(transform.position.x < StartPos.x - MoveLength)
            {
                direction = 1;
            }
            if(LeftOrRight)
            {
                movement = Vector3.right * direction * MoveSpeed;
                transform.Translate(movement * Time.deltaTime);
            }
            else
            {
                movement = Vector3.left * direction * MoveSpeed;
                transform.Translate(movement * Time.deltaTime);   
            }
        }
        else
        {
            if(transform.position.y > MoveLength)
            {
                direction = -1;
            }
            else if(transform.position.y < (-MoveLength))
            {
                direction = 1;
            }
            movement = Vector3.up * direction * MoveSpeed;
            transform.Translate(movement * Time.deltaTime);

        }
    }
    

}
