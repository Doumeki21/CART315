using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //an array of gun types recognized by the player.
    // Gun[] guns;
    
    private float yPos, xPos;
    public float playerSpeed = 1.0f;
    public float topWall, bottomWall, leftWall, rightWall;

    public KeyCode upKey, downKey, leftKey, rightKey;
    
    private bool shoot;
    // Start is called before the first frame update
    void Start()
    {
        //Gets access to all the gun types in all the child game obj.
        // guns = transform.GetComponentsInChildren<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        // moving down (y values increases going up, decreases going down.)
        if (Input.GetKey(downKey)) {
            if (yPos > bottomWall) {
                yPos -= playerSpeed;
            }
        }
        // moving up
        if (Input.GetKey(upKey)) {
            if (yPos < topWall) {
                yPos += playerSpeed;
            }
        }
        // moving left (x values decreases going left, increases going right.)
        if (Input.GetKey(leftKey)) {
            if (xPos > leftWall) {
                xPos -= playerSpeed;
            }
        }
        // moving up
        if (Input.GetKey(rightKey)) {
            if (xPos < rightWall) {
                xPos += playerSpeed;
            }
        }
        transform.localPosition = new Vector3(xPos, yPos, 0);
        
        // shoot = Input.GetKeyDown(KeyCode.P);
        // if (shoot)
        // {
        //     // shoot = false;
        //     foreach(Gun gun in guns)
        //     {
        //         gun.Shoot();
        //     }
        // }
    }
}
