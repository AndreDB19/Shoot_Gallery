using Unity.Mathematics;
using UnityEngine;

public class Alvo : MonoBehaviour
{


    public int direction;
    Vector3 position1;
    Vector3 position2;
    
    private float speed;
    
    int count;

    void Start()
    {


        MovePosition();

        count = 0;
    }

    private void FixedUpdate() 
    {
        transform.Rotate(new Vector3(0f,3f, 0f));
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
                GameController.life -= 1;
            }
        }

        if(count >= 100)
        {
            transform.position = Vector3.MoveTowards(transform.position, position2, speed);
        }

        if(Vector3.Distance(transform.position, position2) < 0.05f && count >= 100)
        {
            Destroy(gameObject);
            GameController.life -= 1;

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
