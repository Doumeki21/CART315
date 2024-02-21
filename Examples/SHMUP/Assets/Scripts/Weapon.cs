using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //Weapon code borrowed from Brackey's "2D shooting in Unity tutorial".
    public Transform firePoint;
    public GameObject bulletPrefab;
    
    public float fireRate = 2F; // 2seconds wait
    private float nextFire = 0.0F;
    
    // public int beamDamage = 80;
    // public GameObject impactBeamEffect;
    // public LineRenderer lineRenderer;

    // Update is called once per frame
    void Update()
    {
        //go to edit >> project settings >> input manager (alt positive button).
        // if (Input.GetKey("n"))
        // {
        //     Shoot();
        // }
        
        //https://discussions.unity.com/t/delay-between-bullet-shot-with-getkey/191520
        if(Input.GetKey("n") && Time.time > nextFire ) {

            nextFire = Time.time + fireRate;
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

    // IEnumerator ShootBeam()
    // {
    //    RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);
    //    
    //    if (hitInfo)
    //    {
    //        Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
    //        if (enemy != null)
    //        {
    //            enemy.TakeDamage(beamDamage);
    //        }
    //        Instantiate(impactBeamEffect, hitInfo.point, Quaternion.identity);
    //        
    //        LineRenderer.SetPosition(0, firePoint.position);
    //        LineRenderer.SetPosition(1, hitInfo.point);
    //    }
    //    else
    //    {
    //        //if the line doesn't hit anything, it continues infinitely in space.
    //        LineRenderer.SetPosition(0, firePoint.position);
    //        LineRenderer.SetPosition(1, firePoint.position + firePoint.right * 100); //take the starting position and shifting it 100 units fold.
    //    }
    //    
    //    //to make this part work, this (void) function needs to be a coroutine
    //    lineRenderer.enabled = true;
    //    //wait 1 frame 
    //    yield return 0;
    //
    //    lineRenderer.enabled = false;
    // }
}
