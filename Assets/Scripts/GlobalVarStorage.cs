///////////////////////////
//// Name; Sim McQueen
//// Date: 11/5/2020
//// Desc: A storage for all global variables
///////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVarStorage : MonoBehaviour
{
    // PLEASE ADD A COMMENT FOR WHAT THE VAR WILL DO
    
    // A var used in other scripts to tell if a level is ongoing or not
    public static bool levelOnGoing = false;
    // A var that can be changed depending on where you want the object that the camera is following to be moving towards
    public static Vector3 CameraMoveTowards;
    // Keeps the direction of the player
    public static Vector3 PlayerDirection;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
