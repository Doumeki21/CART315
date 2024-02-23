using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 200f;
    public int damage = 40;
    public Rigidbody2D rb;
    // public GameObject impactEffect;
    // public AudioSource attackSound, destroyed;
    
    private GameManager manager;
        
    // Use this for initialization
    void Start()
    {
        //velocity is the current speed on the axes.
        rb.velocity = transform.right * speed;
        // manager = GameObject.Find("GameManager");
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
       // hitInfo == enemy or can use to search other obj names!
       //gameobject is whatever this script is linked to (aka. bullets!)
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        PlayerController playerController = hitInfo.GetComponent<PlayerController>();
        
        //if enemy bullet hits player then destroy bullet and player will get damage
        if (gameObject.tag == "EnemyBullet" && playerController != null)
        {
            //implement player damage
            GameManager.Instance.livesScript.UpdateLife();
            Destroy(gameObject);
        }

        //if we actually find an enemy component,
        //if (enemy != null)
         if (enemy != null && hitInfo.transform.position.x < 730 && hitInfo.transform.position.x > -240 )
        {
            //if enemy bullet hits the enemies DO NOTHING
            if(gameObject.tag == "EnemyBullet" && hitInfo.tag =="Enemy"){
                 // Debug.Log("enemy bullet");
            }
          //if enemy bullet hits player's bullet DO NOTHING
             else if (gameObject.tag == "EnemyBullet" && gameObject.tag =="Bullet"){
                
            }
            // if ENEMY BULLET hits none of the above - destroy after 2 secs
            else if(gameObject.tag == "EnemyBullet"){
                 Destroy(gameObject,20);
            }
            //IF IT'S A PLAYER BULLET.
            else if (gameObject.tag == "Bullet"){
                 //Take damage (can input a damage value here or in the public.)
            enemy.TakeDamage(damage);
            //Instantiate(impactEffect, transform.position, transform.rotation);
            // destroyed.pitch = 1f;
            // destroyed.Play();
            Destroy(gameObject);
            
        }
     }
         else
         {
             Destroy(gameObject, 5);
         }
    }
}
