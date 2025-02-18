using UnityEngine;

public class Alvo : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Transform transform;
    float position1;
    float position2;
    int cont = 0;

    void Start()
    {
        transform = GetComponent<Transform>();
        m_Rigidbody = GetComponent<Rigidbody>();
        position1 = transform.position.x+4f;
        position2 = transform.position.x;
    }

    private void FixedUpdate() 
    {
        move();
    }

    private void move()
    {
        if(transform.position.x< position1 && cont == 0)
        {
            m_Rigidbody.Move(new Vector3(transform.position.x+0.05f,transform.position.y,transform.position.z),transform.rotation);
        }
        else
        {
            cont++;
        }

        if(cont >= 150 && transform.position.x> position2)
        {
            m_Rigidbody.Move(new Vector3(transform.position.x-0.05f,transform.position.y,transform.position.z),transform.rotation);
        }
        else if(cont >= 150)
        {
            Destroy(gameObject);
        }
    }

}
