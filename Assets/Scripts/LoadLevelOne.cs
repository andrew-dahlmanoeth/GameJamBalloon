//////////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/12
//// Desc: A function to run when the start button is pressed
//////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOne : MonoBehaviour
{
    public void LoadFirstLevel()
    {
        StartCoroutine(WaitBeforeStart());

        
    }

    IEnumerator WaitBeforeStart()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}
