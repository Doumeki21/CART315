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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        Destroy(gameObject);
        // Instantiate(deathEffect, transform.position, Quaternion.identity);
        
    }

    private void FixedUpdate()
    {
        //enemy moves from right to left.
        rb.velocity = -1 * transform.right * enemySpeed;
        if (transform.position.x < -90)
        {
            Destroy(gameObject);
        }
    }
}
