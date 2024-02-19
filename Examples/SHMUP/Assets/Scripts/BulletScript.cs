using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
        
    // Use this for initialization
    void Start()
    {
        //velocity is the current speed on the axes.
        rb.velocity = transform.right * speed;
    }
}
