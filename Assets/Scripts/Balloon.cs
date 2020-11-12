///////////////////////////
//// Name: Sim McQueen
//// Date: 11/5
//// Desc: Helps add value to balloons
///////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Balloon : MonoBehaviour
{
    public int CoinValue = 1;
    public UnityEvent OnCollect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(CoinValue);
            OnCollect.Invoke();
        }
    }

}
