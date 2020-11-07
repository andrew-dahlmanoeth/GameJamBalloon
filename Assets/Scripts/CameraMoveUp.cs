/////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/4
//// Desc: Moves an object to a point for the camera to follow
/////////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveUp : MonoBehaviour
{

    private Vector3 MoveTowards;

    public float speed = 2;



    // Start is called before the first frame update
    void Start()
    {
        GlobalVarStorage.levelOnGoing = true;

        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 MoveTowards = GlobalVarStorage.CameraMoveTowards;

        transform.position = Vector3.MoveTowards(transform.position, MoveTowards, speed * Time.deltaTime);
    }











}
