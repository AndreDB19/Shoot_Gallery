using UnityEditor.Experimental;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject AlvoNormal;
    public GameObject AlvoRapido;
    private int count = 0;

    public Alvo[] script;
    // Update is called once per frame
    void FixedUpdate()
    {
        count++;

        switch (count)
        {
            case 300:
                Instantiate(AlvoNormal, transform);
                script = GetComponentsInChildren<Alvo>();
                foreach (Alvo direction in script)
                {
                    direction.direction = 1;
                }
                break;

            case 1100:
                Instantiate(AlvoNormal, transform);
                script = GetComponentsInChildren<Alvo>();
                foreach (Alvo direction in script)
                {
                    direction.direction = 1;
                }
                break;

            case 1400:
                Instantiate(AlvoRapido, transform);
                script = GetComponentsInChildren<Alvo>();
                foreach (Alvo direction in script)
                {
                    direction.direction = 3;
                }
                break;

            case 1425:
                Instantiate(AlvoRapido, transform);
                script = GetComponentsInChildren<Alvo>();
                foreach (Alvo direction in script)
                {
                    direction.direction = 3;
                }
                break;

            

        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
                Application.Quit();
        }

    }
}
