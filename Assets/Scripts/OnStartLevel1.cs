///////////////////////////////
//// Name: Sim McQueen
//// Date: 11/6
//// Desc: A few things to do when the scene is loaded
//////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartLevel1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GlobalVarStorage.CameraMoveTowards = new Vector3(0,30,-10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
