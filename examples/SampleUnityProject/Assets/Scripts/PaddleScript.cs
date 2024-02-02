using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    private float yPos;
    public float paddleSpeed = 0.2f;
    public float topWall, bottomWall;

    public KeyCode upKey, downKey;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // moving down
        if (Input.GetKey(downKey)) {
            if (yPos > bottomWall) {
                yPos -= paddleSpeed;
            }
        }

        // moving up
        if (Input.GetKey(upKey)) {
            if (yPos < topWall) {
                yPos += paddleSpeed;
            }
        }

        transform.localPosition = new Vector3(transform.position.x, yPos, 0);
    }
}
