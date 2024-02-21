using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
    public bool canBeDestroyed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 730)
        {
            canBeDestroyed = true;
        }
        //if the enemy can't be destroyed-
        else
        {
            return;
        }
    }
}
