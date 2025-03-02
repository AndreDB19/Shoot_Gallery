using UnityEngine;

public class Alvo : MonoBehaviour
{
    Transform transform;

    public int direction;
    Vector3 position1;
    Vector3 position2;
    

    private float speed;
    
    int count;

    void Start()
    {
        transform = GetComponent<Transform>();

        MovePosition();

        count = 0;
    }

    private void FixedUpdate() 
    {
        move();
    }

    private void move()
    {

        if(count == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, position1, speed);
        }

        if((Vector3.Distance(transform.position, position1) < 0.05f))
        {
            count++;
            if(direction == 3 || direction == 4)
            {
                Destroy(gameObject);
            }
        }

        if(count >= 150)
        {
            transform.position = Vector3.MoveTowards(transform.position, position2, speed);
        }

        if(Vector3.Distance(transform.position, position2) < 0.05f && count >= 150)
        {
            Destroy(gameObject);
        }
    }

    private void MovePosition()
    {
        if(direction == 1)
        {
            position1 = new Vector3(transform.position.x+5f, transform.position.y, transform.position.z);
            position2 = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            speed = 0.5f;
        }
        else if(direction == 2)
        {
            position1 = new Vector3(transform.position.x-5f, transform.position.y, transform.position.z);
            position2 = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            speed = 0.5f;
        }
        else if(direction == 3)
        {
            position1 = new Vector3(transform.position.x+20f, transform.position.y, transform.position.z);
            speed = 0.25f;
        }
        else if(direction == 4)
        {
            position1 = new Vector3(transform.position.x-20f, transform.position.y, transform.position.z);
            speed = 0.25f;

        }
        else if(direction == 5)
        {
            position1 = new Vector3(transform.position.x, transform.position.y+5, transform.position.z);
            position2 = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            speed = 0.25f;
        }
    }

}
