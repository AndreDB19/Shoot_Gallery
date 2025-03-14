using UnityEditor.Experimental;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    Rigidbody rb;

    public float bulletSpeed = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed, ForceMode.VelocityChange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bala colidiu com:"  + collision.gameObject.name);
        Destroy(gameObject);

    }

}
