using UnityEditor.Experimental;
using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{

    public GameObject AlvoNormal;
    public GameObject AlvoRapido;
    public GameObject AlvoPulante;

    public GameObject spawnEsquerda;
    public GameObject spawnDireita;
    public GameObject spawnCentro;

    private int spawner;
    private int alvo;

    public Alvo[] script;

    void Start()
    {

        StartCoroutine(Spawning());

    }

    public IEnumerator Spawning()
    {
        yield return new WaitForSeconds(2f);
        spawner = Random.Range(1, 4);
            
            if(spawner == 3){
                Instantiate(AlvoPulante, spawnCentro.transform);
                script = spawnCentro.GetComponentsInChildren<Alvo>();
                foreach (Alvo direction in script)
                {
                    direction.direction = 5;
                }
                yield return new WaitForSeconds(3f);
            }
            else
            {
                alvo = Random.Range(1, 4);
                switch(spawner)
                {
                    case 1:
                        if(alvo == 1){
                            Instantiate(AlvoNormal, spawnEsquerda.transform);
                            script = spawnEsquerda.GetComponentsInChildren<Alvo>();
                            foreach (Alvo direction in script)
                            {
                                direction.direction = 1;
                            }
                            yield return new WaitForSeconds(2f);
                        }
                        if(alvo == 2){
                            Instantiate(AlvoRapido, spawnEsquerda.transform);
                            script = spawnEsquerda.GetComponentsInChildren<Alvo>();
                            foreach (Alvo direction in script)
                            {
                                direction.direction = 3;
                            }
                            yield return new WaitForSeconds(1f);
                        }
                        if(alvo == 3){
                            Instantiate(AlvoRapido, spawnEsquerda.transform);
                            script = spawnEsquerda.GetComponentsInChildren<Alvo>();
                            script = spawnEsquerda.GetComponentsInChildren<Alvo>();
                            foreach (Alvo direction in script)
                            {
                                direction.direction = 3;
                            }

                            yield return new WaitForSeconds(0.25f);

                            Instantiate(AlvoRapido, spawnEsquerda.transform);
                            script = spawnEsquerda.GetComponentsInChildren<Alvo>();
                            foreach (Alvo direction in script)
                            {
                                direction.direction = 3;
                            }
                            yield return new WaitForSeconds(1f);
                        }
                    break;
                    case 2:
                    if(alvo == 1){
                            Instantiate(AlvoNormal, spawnDireita.transform);
                            script = spawnDireita.GetComponentsInChildren<Alvo>();
                            foreach (Alvo direction in script)
                            {
                                direction.direction = 2;
                            }
                            yield return new WaitForSeconds(2f);
                        }
                        if(alvo == 2){
                            Instantiate(AlvoRapido, spawnDireita.transform);
                            script = spawnDireita.GetComponentsInChildren<Alvo>();
                            foreach (Alvo direction in script)
                            {
                                direction.direction = 4;
                            }
                            yield return new WaitForSeconds(1f);
                        }
                        if(alvo == 3){
                            Instantiate(AlvoRapido, spawnDireita.transform);
                            script = spawnDireita.GetComponentsInChildren<Alvo>();
                            foreach (Alvo direction in script)
                            {
                                direction.direction = 4;
                            }
                            
                            yield return new WaitForSeconds(0.25f);

                            Instantiate(AlvoRapido, spawnDireita.transform);
                            script = spawnDireita.GetComponentsInChildren<Alvo>();
                            foreach (Alvo direction in script)
                            {
                                direction.direction = 4;
                            }
                            yield return new WaitForSeconds(1f);
                        }
                    break;
                }
            }
        StartCoroutine(Spawning());
    }
}
