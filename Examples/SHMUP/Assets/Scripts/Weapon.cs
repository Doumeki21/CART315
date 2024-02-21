using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //Most of this code borrowed from Brackey's "2D shooting in Unity tutorial".
    public Transform firePoint;
    public GameObject bulletPrefab;
    
    public float fireRate = 2F; // 2seconds wait
    private float nextFire = 0.0F;

    //https://www.youtube.com/watch?v=C7JRl9QoxIo&t=291s&ab_channel=superjustin5000
    public bool autoShoot = false;
    public float shootIntervalSeconds = 0.1f;
    public float shootDelaySeconds = 2.0f;
    public float shootTimer = 0f;
    public float delayTimer = 0f;

    // Update is called once per frame
    void Update()
    {
        //go to edit >> project settings >> input manager (alt positive button).
        // if (Input.GetKey("n"))
        // {
        //     Shoot();
        // }

        //https://discussions.unity.com/t/delay-between-bullet-shot-with-getkey/191520
        if (Input.GetKey("n") && Time.time > nextFire)
        {

            nextFire = Time.time + fireRate;
            Shoot();
        }
        
            if (autoShoot)
            {
                if (delayTimer >= shootDelaySeconds)
                {
                    if (shootTimer >= shootIntervalSeconds)
                    {
                        Shoot();
                        shootTimer = 0; //reset timer.
                    }
                    else
                    {
                        //keep incrementing the time.
                        shootTimer += Time.deltaTime;
                    }
                }
                else
                {
                    delayTimer += Time.deltaTime;
                }
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
