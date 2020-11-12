/////////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/12/20
//// Desc: A couple things to do when the game starts
/////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Player Score", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
