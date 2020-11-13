//////////////////////////
///Name: Melanie Baloban
///Date: 11/8/20
///Desc: Makes the enemy move in a random direction every 2 seconds
//////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float waitTime = 0.5f;
    public float minSpeed = 1f;
    public float maxSpeed = 2f;
    private Vector2 movement;
    private float timeLeft;
    Rigidbody2D myRb;

    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft += Time.deltaTime;

        if(timeLeft >= waitTime)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft = 0;
        }

    }

    void FixedUpdate()
    {
        myRb.AddForce(movement * Random.Range(minSpeed, maxSpeed));
    }

}
