using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float yPos, xPos;
    public float playerSpeed = 1.0f;
    public float topWall, bottomWall, leftWall, rightWall;

    public KeyCode upKey, downKey, leftKey, rightKey;
    // Start is called before the first frame update
    void Start()
    {
        
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

        transform.localPosition = new Vector3(transform.position.x, yPos, 0);
    }
}
