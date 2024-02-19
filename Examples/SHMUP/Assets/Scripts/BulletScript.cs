using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public Vector2 direction = new Vector2(1,0);  //moves the bullet to the right
    public float bulletSpeed = 200f;
    
    public Vector2 velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        //destroy this game object (the bullet) after a number of seconds.
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        velocity = direction * bulletSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos += velocity * Time.fixedDeltaTime;
        transform.position = pos;
    }
}
