﻿//////////////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/9
//// Desc: Switches Scenes once touched with another object
//////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveLevels : MonoBehaviour
{
    [SerializeField] private string newLevel;


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            ScoreTracker.score = ScoreTracker.balloons;
            PlayerPrefs.SetInt("Player Score", ScoreTracker.score);
            SceneManager.LoadScene(newLevel);
        }
    }

}
