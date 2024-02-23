using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    // public GameObject deathEffect;
    public Rigidbody2D rb;
    public float enemySpeed = 100;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //enemy checks to see if the bullet comes from their own.
        if (hitInfo.gameObject.tag == "Player")
        {
            GameManager.Instance.livesScript.UpdateLife();
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;  
    
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        // Quaternion.identity basically means no rotation!!
        GameManager.Instance.scoreScript.UpdateScore();
        Destroy(gameObject);
        // Instantiate(deathEffect, transform.position, Quaternion.identity);
        
    }

    private void FixedUpdate()
    {
        //MOVEMENT
        //enemy moves from right to left.
        rb.velocity = -1 * transform.right * enemySpeed;
        if (transform.position.x < -90)
        {
            Destroy(gameObject);
        }
    }
}
