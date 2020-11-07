////////////////////////////
//// Name: Sim McQueen
//// Date: 11/5/2020
//// Desc: Handles the score text
////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScore(int CoinValue)
    {
        score += CoinValue;

        text.text = "Balloons: " + score.ToString();
    }


}
