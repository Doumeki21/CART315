using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    // public GameObject impactEffect;
    
    public GameObject manager;
        
    // Use this for initialization
    void Start()
    {
        //velocity is the current speed on the axes.
        rb.velocity = transform.right * speed;
        manager = GameObject.Find("GameManager");

        Debug.Log(manager.GetComponent<ScoreScript>().score);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
       // hitInfo == enemy or can use to search other obj names!
       //gameobject is whatever this script is linked to (aka. bullets!)
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        // Lives lives = manager.GetComponent<LivesScript>();

        //if we actually find an enemy component,
        //if (enemy != null)
         if (enemy != null && hitInfo.transform.position.x < 730 && hitInfo.transform.position.x > -240 )
        {
            //if enemy bullet hits the enemies DO NOTHING
            if(gameObject.tag == "EnemyBullet" && hitInfo.tag =="Enemy"){
                 Debug.Log("enemy bullet");
            }
            //if enemy bullet hits player then destroy bullet and player will get damage
            else if (gameObject.tag == "EnemyBullet" && hitInfo.name =="Player"){
                Debug.Log("player hit");
                //implement player damage
                
                Destroy(gameObject);
            }
          //if enemy bullet hits a hexagon DO NOTHING
            //  else if (gameObject.tag == "EnemyBullet" && hitInfo.tag =="Enemy"){
            //     Debug.Log("hex enemy was hit");
            // }
            // if ENEMY BULLET hits none of the above - destroy after 2 secs
            else if(gameObject.tag == "EnemyBullet"){
                 Destroy(gameObject,2);
            }
            //IF IT'S A PLAYER BULLET.
            else if (gameObject.tag == "Bullet"){
                 //Take damage (can input a damage value here or in the public.)
            enemy.TakeDamage(damage);
            //Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        } 

     }
           
       
        // else{
        //     //Take damage (can input a damage value here or in the public.)
        //     enemy.TakeDamage(damage);
        //     //Instantiate(impactEffect, transform.position, transform.rotation);
        //     Destroy(gameObject);
        // }
        //}
        // else
        // {
        //     Destroy(gameObject, 2);
        // }
    }
}
