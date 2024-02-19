using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //Weapon code borrowed from Brackey's "2D shooting in Unity tutorial".
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        //go to edit >> project settings >> input manager (alt positive button).
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //Shooting logic.
        //use instantiate whenever we need to spawn things!
        //Instantiate(what, where, rotation);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
