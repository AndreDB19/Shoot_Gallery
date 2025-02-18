
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Slingshot : MonoBehaviour
{
    [@SerializeField]
    public int bullets = 20;
    public float fireDelay = 1f;
    public float bulletSpeed = 2f;
    public GameObject bullet;

    private bool canFire = true;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && canFire == true && bullets >= 1)
        {
            fire(bulletSpeed);
        }

    }

    public void fire(float speed)
    {
        //Instantiate
        bullets--;
        StartCoroutine(fireRate(fireDelay));
    }
    public IEnumerator fireRate(float fireDelay)
    {
        canFire = false;
        yield return new WaitForSeconds(fireDelay);
        canFire = true;
    }

}
