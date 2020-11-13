////////////////////////////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/12
//// Desc: Waits a couple seconds then moves onto levl 2
////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOneCompleted : MonoBehaviour
{
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadLevelTwo());
    }

    IEnumerator LoadLevelTwo()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }

    
}
