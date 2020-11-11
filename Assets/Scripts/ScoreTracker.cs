using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public int score;
    public int balloons;



    void Start()
    {
        score = PlayerPrefs.GetInt("Player Score");


    }

    
}
