using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCloudMove : MonoBehaviour
{
    private float num;
    private float MoveSpeed = 0;
    private int direction = 1;
    private Vector3 StartPos;
    Vector3 movement;
    Rigidbody2D myRB;

    void NewCloud()
    {
        // Set speed in range of -4 to -1, or 1 to 4
        while(MoveSpeed < 0.5f && MoveSpeed > -0.5f)
        {
            MoveSpeed = Random.Range(-3.0f, 3.0f);
        }
        // Set random scale
        num = Random.Range(5.0f, 12.0f);
        transform.localScale = new Vector3(num,num,num);

    }
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        NewCloud();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement = Vector3.right * direction * MoveSpeed;
        transform.Translate(movement * Time.deltaTime);
    }
    
    void OnBecameInvisible() 
    {
        StartPos = transform.position;
        StartPos.x = -StartPos.x * 1.2f;
        transform.position = StartPos;
        NewCloud();
    }
}
