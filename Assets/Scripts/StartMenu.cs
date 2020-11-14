using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject OptionsMenu;
    public GameObject StartingMenu;

    void Start()
    {
        OptionsMenu.SetActive(false);
    }

    public void Options()
    {
        StartingMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void Back()
    {
        StartingMenu.SetActive(true);
        OptionsMenu.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
