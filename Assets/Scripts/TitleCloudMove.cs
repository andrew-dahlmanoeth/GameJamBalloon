using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCloudMove : MonoBehaviour
{  
    [Tooltip("Minimum number the GameObject may be scaled to")]
    public float ScaleRangeLow = 5.0f;
    [Tooltip("Maximum number the GameObject may be scaled to")]
    public float ScaleRangeHigh = 12.0f;
    [Tooltip("Minimum speed the GameObject may move at")]
    public float SpeedRangeLow = 0.5f;
    [Tooltip("Maximum speed the GameObject may move at")]
    public float SpeedRangeHigh = 3.0f;
    private float num;
    private float MoveSpeed = 0;
    private int direction = 1;
    private Vector3 StartPos;
    Vector3 movement;
    Rigidbody2D myRB;

    void NewCloud()
    {
        // Set speed in range of -4 to -1, or 1 to 4
        while(MoveSpeed < SpeedRangeLow && MoveSpeed > -SpeedRangeLow)
        {
            MoveSpeed = Random.Range(-SpeedRangeHigh, SpeedRangeHigh);
        }
        // Set random scale
        num = Random.Range(ScaleRangeLow, ScaleRangeHigh);
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
