using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SineMovement : MonoBehaviour
{
    public float waveSize = 10.0f; // Scaling factor for the sine wave
    public float waveLength = 8.0f; // Controls the length of the wave (to reduce the jitterness)
    private float sinCenterY; // shifting the sine function position, so that it doesn't start b/w 1 and -1 by default.

    public bool inverted = false;
    
    // Start is called before the first frame update
    void Start()
    {
        sinCenterY = transform.position.y;
    }

//Source: https://youtu.be/YtRxkWoTl_o?si=6MTsHeNBtyvDG-y9
    private void FixedUpdate()
    {
        float sin = Mathf.Sin(Time.time * waveLength) * waveSize; // Adjust wave length by multiplying with waveLength
        if (inverted)
        {
            sin *= -1;
        }
        //because i can't directly change transform.position.y... Use "newPosition.y" instead
        Vector3 newPosition = transform.position;
        newPosition.y = sinCenterY + sin; // Apply scaling to the sine wave
        transform.position = newPosition;
    }
}
