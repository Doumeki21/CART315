using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    //What type of bullet this gun shoots
    public Bullet bullet;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        //Creates a copy of this bullet at the gameobject 
        GameObject go = Instantiate(bullet.gameObject, transform.position, Quaternion.identity);
    }
}
