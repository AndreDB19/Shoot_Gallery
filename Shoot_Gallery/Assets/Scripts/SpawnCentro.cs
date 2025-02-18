using UnityEngine;

public class SpawnCentro : MonoBehaviour
{


    public GameObject AlvoPulante;
    private int count = 0;

    public Alvo[] script;

    void FixedUpdate()
    {
        count++;

        switch (count)
        {
            case 100:
                Instantiate(AlvoPulante, transform);
                script = GetComponentsInChildren<Alvo>();
                foreach (Alvo direction in script)
                {
                    direction.direction = 5;
                }
                break;

            case 800:
                Instantiate(AlvoPulante, transform);
                script = GetComponentsInChildren<Alvo>();
                foreach (Alvo direction in script)
                {
                    direction.direction = 5;
                }
                break;
            

        }

    }
}
