/////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/4
//// Desc: Moves an object somewhere
/////////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSomewhere : MonoBehaviour
{

    public Vector3 MoveTowards;

    public float speed = 2;



    // Start is called before the first frame update
    void Start()
    {
        

        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        

        transform.position = Vector3.MoveTowards(transform.position, MoveTowards, speed * Time.deltaTime);
    }











}
