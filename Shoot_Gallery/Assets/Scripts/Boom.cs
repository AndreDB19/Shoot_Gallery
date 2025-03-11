using UnityEngine;

public class Boom : MonoBehaviour
{
    // Referência para o prefab do sprite que será instanciado
    public GameObject boom;

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se o objeto que colidiu tem a tag "Projectile"
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // Instancia o sprite no ponto de colisão
            Debug.Log("Colisão detectada com: " + collision.gameObject.name);
            Vector3 collisionPoint = collision.contacts[0].point;

            // Instancia o prefab "boom" no ponto de colisão
            GameObject spriteInstance = Instantiate(boom, collisionPoint, Quaternion.identity);
            Debug.Log("Sprite instanciado: " + spriteInstance.name);

            // Destrua a bala (opcional, se você quiser que a bala desapareça após a colisão)
            Destroy(collision.gameObject);
            Debug.Log("Bala destruída: " + collision.gameObject.name);
        }
    }
}