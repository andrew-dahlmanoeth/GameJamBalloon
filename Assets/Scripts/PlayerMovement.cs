//////////////////////
///Name: Andrew Dahlman-Oeth
///Date: 11/3/2020
///Description: 2D player controller
//////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Player speed - left/right")]
    public float Speed = 5;
    [Tooltip("Amount of force the player jumps with")]
    public float JumpForce = 1;
    private float MoveInput;

    Rigidbody2D myRB;

    private bool FacingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        // MoveInput equals 1 if moving right, -1 if moving left
        MoveInput = Input.GetAxisRaw("Horizontal");
        myRB.velocity = new Vector2(MoveInput * Speed, myRB.velocity.y);

        // Flip the player sprite if direction changes
        if(FacingRight == false && MoveInput > 0)
        {
            Flip();
        }
        else if(FacingRight == true && MoveInput < 0)
        {
            Flip();
        }
    }

    // Used to flip direction of player when direction change occurs
    void Flip()
    {
        FacingRight = !FacingRight;
        // Get the players' local xyz scale values
        Vector3 Scaler = transform.localScale;
        // Flip the x value
        Scaler.x = Scaler.x * -1;
        // Set the new scaler values
        transform.localScale = Scaler;

    }
}
