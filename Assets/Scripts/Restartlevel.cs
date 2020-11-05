/////////////eddie zhao 
/////////11/4/20
//////////////descrpition: when the charter reaces the bottom restart the level

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restartlevel : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))///how to active the code 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//// what will it do when the key is pressed 
        } 
        
    }
}
