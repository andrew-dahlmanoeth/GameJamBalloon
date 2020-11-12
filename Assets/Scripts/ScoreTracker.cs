using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public static int score;
    public static int balloons;



    void Start()
    {
        score = PlayerPrefs.GetInt("Player Score");
        balloons = score;

    }

    
}
