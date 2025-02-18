using UnityEngine;

public class SpawnDireita : MonoBehaviour
{

    public GameObject AlvoNormal;
    public GameObject AlvoRapido;
    private int count = 0;

    public Alvo[] script;

    void FixedUpdate()
    {
        count++;

        switch (count)
        {
            case 500:
                Instantiate(AlvoNormal, transform);
                script = GetComponentsInChildren<Alvo>();
                foreach (Alvo direction in script)
                {
                    direction.direction = 2;
                }
                break;

            case 1100:
                Instantiate(AlvoNormal, transform);
                script = GetComponentsInChildren<Alvo>();
                foreach (Alvo direction in script)
                {
                    direction.direction = 2;
                }
                break;

            case 1500:
                Instantiate(AlvoRapido, transform);
                script = GetComponentsInChildren<Alvo>();
                foreach (Alvo direction in script)
                {
                    direction.direction = 4;
                }
                break;

            case 1525:
                Instantiate(AlvoRapido, transform);
                script = GetComponentsInChildren<Alvo>();
                foreach (Alvo direction in script)
                {
                    direction.direction = 4;
                }
                break;

            

        }

    }
}
