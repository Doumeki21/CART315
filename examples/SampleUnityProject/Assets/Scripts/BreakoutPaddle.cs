using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakoutPaddle : MonoBehaviour
{
    private float xPos;
    public float paddleSpeed = 0.2f;
    public float leftKey, rightKey;

    public KeyCode leftKey, rightKey;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // moving down
        if (Input.GetKey(leftKey)) {
            if (xPos > leftWall) {
                xPos -= paddleSpeed;
            }
        }

        // moving up
        if (Input.GetKey(rightKey)) {
            if (xPos < rightWall) {
                xPos += paddleSpeed;
            }
        }

        transform.localPosition = new Vector3(transform.position.x, yPos, 0);
    }
}
