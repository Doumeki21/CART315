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

    public bool isEnemy = false;
        
    // Use this for initialization
    void Start()
    {
        //velocity is the current speed on the axes.
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(gameObject.name);
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        //if we actually find an enemy component,
        if (enemy != null && hitInfo.transform.position.x < 730)
        {
            if (gameObject.tag == "EnemyBullet" && hitInfo.name == "EnemyType2")
            {
                Debug.Log("enemy bullet");
            }
            else
            {
                //Take damage (can input a damage value here or in the public.)
                enemy.TakeDamage(damage);
                // Instantiate(impactEffect, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            
        } 
        // else
        // {
        //     Destroy(gameObject, 2);
        // }
        //
        // if (hitInfo.gameObject.tag == "EnemyBullet")
        // {
        //     enemy.TakeDamage(0);
        // }
        
    }
}
