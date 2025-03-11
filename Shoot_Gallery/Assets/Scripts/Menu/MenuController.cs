using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuController : MonoBehaviour
{
    private bool MenuState;

    public Canvas UI;
    public Canvas Menu;

    void Start()
    {
        MenuState = true;
        Pause();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Pause();
        }
    }

    void Pause() {
        if(MenuState == false)
        {
            MenuState = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            UI.enabled = false;
            Menu.enabled = true;
            Time.timeScale = 0;
        }
        else
        {
            MenuState = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            UI.enabled = true;
            Menu.enabled = false;
            Time.timeScale = 1;
        }
    }
}
