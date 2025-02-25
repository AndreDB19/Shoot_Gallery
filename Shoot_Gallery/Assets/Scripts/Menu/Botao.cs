using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Botao : MonoBehaviour
{
public Canvas Menu;
public Canvas Tutorial;
void Start()
{
    Menu.enabled = true;
    Tutorial.enabled = false;
}
public void Jogar()
{
    SceneManager.LoadScene("SampleScene");
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

}
