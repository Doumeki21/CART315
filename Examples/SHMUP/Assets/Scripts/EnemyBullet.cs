using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //velocity is the current speed on the axes.
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //enemies that get hit by enemy bullets shouldn't take dmg.
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (hitInfo.gameObject.tag == "Enemy")
        {
            enemy.TakeDamage(0);
        }
    }
}
