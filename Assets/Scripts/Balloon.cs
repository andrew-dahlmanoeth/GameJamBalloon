///////////////////////////
//// Name: Sim McQueen
//// Date: 11/5
//// Desc: Helps add value to balloons
///////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int CoinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger");
        if(other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(CoinValue);
        }
    }

}
