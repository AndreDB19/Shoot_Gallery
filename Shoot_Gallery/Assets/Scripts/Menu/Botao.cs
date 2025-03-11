using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Botao : MonoBehaviour
{
    public Canvas Menu;
    public Canvas Tutorial;

    public string cena;
    void Start()
    {
        Menu.enabled = true;
        Tutorial.enabled = false;
    }
    public void Jogar()
    {
        SceneManager.LoadScene(cena);
    }

    public void Sair()
    {
        Application.Quit();
    }

    public void ComoJogar()
    {
        if(Menu.enabled == true)
        {
            Menu.enabled = false;
            Tutorial.enabled = true;
        }
        else
        {
            Menu.enabled = true;
            Tutorial.enabled = false;
        }

    }

    public void reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    

}
