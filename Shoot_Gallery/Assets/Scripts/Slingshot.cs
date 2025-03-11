
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Slingshot : MonoBehaviour
{
    [@SerializeField]


    public float fireDelay;


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
