//////////////////////
///Name: Andrew Dahlman-Oeth
///Date: 11/4/2020
///Description: Open and close the menu with this script
//////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject PauseMenu;
    public GameObject OptionsMenu;

    void Start() 
    {
        PauseMenu.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
        GamePaused = false;

    }

    void Pause()
    {
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);
        GamePaused = true;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Options()
    {
        PauseMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }
}
