using UnityEngine;

public class Target : MonoBehaviour
{
    public int points = 10; // Pontos que o objeto vale

    private void OnCollisionEnter(Collision collision)
    {
        
        // Verifica se o objeto foi acertado por algo (por exemplo, um projétil)
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // Destroi o objeto
            Destroy(gameObject);
            // Adiciona pontos ao ScoreManager
            ScoreManager.Instance.AddScore(points);
            
            
        }
    }
}