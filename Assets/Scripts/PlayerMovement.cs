//////////////////////
///Name: Andrew Dahlman-Oeth
///Date: 11/3/2020
///Description: 2D player controller
//////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Player speed - left/right")]
    public float Speed = 5;
    [Tooltip("Amount of force the player jumps with")]
    public float JumpForce = 10;
    [Tooltip("A list of things to do when we jump")]
    public UnityEvent OnJump = new UnityEvent();
    public float FallMultiplier = 2.5f;
    public float LowJumpMultiplier = 2;

    private Vector3 Jump;
    private float MoveInput;

    Rigidbody2D myRB;

    private bool FacingRight = true;
    private bool OnGround = true;


    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        Jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void Update()
    {
        // MoveInput equals 1 if moving right, -1 if moving left
        MoveInput = Input.GetAxisRaw("Horizontal");
        myRB.velocity = new Vector2(MoveInput * Speed, myRB.velocity.y);

        // Detect when player presses W (jump)
        if(Input.GetKeyDown(KeyCode.W) && OnGround == true)
        {
            // Add an upward force
            // myRB.AddForce(Jump * JumpForce, ForceMode2D.Impulse);
            myRB.velocity = Vector2.up * JumpForce;
            // Spawn in a sound and maybe a particle system for jump?
            OnJump.Invoke();
            OnGround = false;
        }

        if(myRB.velocity.y < 0)
        {
            myRB.velocity += Vector2.up * Physics2D.gravity.y * (FallMultiplier - 1) * Time.deltaTime;
        }
        else if(myRB.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            myRB.velocity += Vector2.up * Physics2D.gravity.y * (LowJumpMultiplier - 1) * Time.deltaTime;
        }

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

    // If the player collides with a GameObject w/ the right tag, reset their jump
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("MovingPlatform"))
        {
            transform.SetParent(collision.transform);
            // Reset jump
            OnGround = true;
        }
        if(collision.gameObject.CompareTag("Ground"))
        {
            OnGround = true;
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("MovingPlatform"))
        {
            transform.SetParent(null);
        } 
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Balloon"))
        {
            
            Destroy(other.gameObject);
        }
    }
}
