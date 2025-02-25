using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    Rigidbody rb;

    public float bulletSpeed = 2f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bala colidiu com:"  + collision.gameObject.name);
        // Verifica se o objeto atingiu algo
        if (collision.gameObject.CompareTag("alvos") || collision.gameObject.CompareTag("Wall"))
        {
            // Destroi o objeto
            Destroy(gameObject);
        }
    }

}
