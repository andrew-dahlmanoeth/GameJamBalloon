//////////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/13/20
//// Desc: Runs when the character dies
//////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnDeath : MonoBehaviour
{
    
    

    void Start()
    {
        StartCoroutine(whenPlayerDies());
    }

    IEnumerator whenPlayerDies()
    {
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
