using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

//give feedback to the player when the bttn is pressed. 
public class ButtonControllerT : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    public Sprite switchedImage;
    private Sprite currentImage; 

    public KeyCode keyToPress;
    public KeyCode secondKey;
    public KeyCode switchKey;

    public String matcher ="";
    
    // Start is called before the first frame update
    void Start()
    {
        //Assign the SR to whatever the same object the bttn controller is on.
        theSR = GetComponent<SpriteRenderer>();
        currentImage = defaultImage;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            theSR.sprite = pressedImage;
             matcher = currentImage.name;
             Debug.Log("in button controller");
             Debug.Log(matcher);
        }

        if (Input.GetKeyUp(keyToPress))
        {
            theSR.sprite = currentImage;
             matcher = currentImage.name;
        }
        
        // Check for the switch key press (switch colors)
        if (Input.GetKeyDown(switchKey))
        {
            if (gameObject.name == "redDefault" || gameObject.name == "blueDefault")
            {
                if (currentImage == defaultImage)
                {
                    currentImage = switchedImage;
                    theSR.sprite = currentImage;
                     matcher = currentImage.name;
                }
                else
                {
                    currentImage = defaultImage;
                    theSR.sprite = currentImage;
                     matcher = currentImage.name;
                }
            }
            // if (gameObject.name == "redDefault")
            // {
            //     colorSwitcher.SwitchRedColor();
            // }
            // else if (gameObject.name == "blueDefault")
            // {
            //     colorSwitcher.SwitchBlueColor();
            // }
        }
    }

    // private void OnCollisionEnter2D(Collision2D other)
    // {
    //     if (other.gameObject.CompareTag("Double"))
    //     {
    //         if (Input.GetKeyDown(keyToPress) && Input.GetKeyDown(secondKey))
    //         {
    //             
    //         }
    //     }
    // }
}
