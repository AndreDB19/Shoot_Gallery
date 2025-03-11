
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Slingshot : MonoBehaviour
{
    [@SerializeField]
<<<<<<< HEAD
    public int bullets = 15;
    public float fireDelay = 10f;
=======

    public float fireDelay;
>>>>>>> 4e93cf9323c2f05a0281e1680387bc9fe3a99567

    public GameObject playerObj;
    public GameObject bullet;

    private bool canFire = true;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && canFire == true )
        {
            fire();
        }

    }

    public void fire()
    {
        Instantiate(bullet, playerObj.transform.position, playerObj.transform.rotation);
        StartCoroutine(fireRate(fireDelay));
    }
    public IEnumerator fireRate(float fireDelay)
    {
        canFire = false;
        yield return new WaitForSeconds(fireDelay);
        canFire = true;
        Debug.Log("Atirar:"  + canFire);
    }

}
