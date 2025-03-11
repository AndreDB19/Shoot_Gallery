using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEditor;
//using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    private bool MenuState;

    public Canvas UI;
    public Canvas Menu;
    public Button continuar;

    public static int life;


    void Start()
    {
        MenuState = true;
        life = 5;
        continuar.onClick.AddListener(OnClick);
        Pause();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Pause();
            Debug.Log(life);
        }
        if(life == 0)
        {
            Pause();
        }
    }

    void Pause() {
        if(MenuState == false)
        {
            MenuState = true;
            UnityEngine.Cursor.lockState = CursorLockMode.None;
            UnityEngine.Cursor.visible = true;
            UI.enabled = false;
            Menu.enabled = true;
            Time.timeScale = 0;
            if(life == 0)
            {
                //continuar.clicked += OnClick;
            }
        }
        else if(MenuState == true && life >0 )
        {
            MenuState = false;
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
            UnityEngine.Cursor.visible = false;
            UI.enabled = true;
            Menu.enabled = false;
            Time.timeScale = 1;
        }
    }
    void OnClick()
    {
        if(life >0)
        {
            Pause();
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
