using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//give feedback to the player when the bttn is pressed. 
public class ButtoController : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        //Assign the SR to whatever the same object the bttn controller is on.
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            theSR.sprite = pressedImage;
        }

        if (Input.GetKeyUp(keyToPress))
        {
            theSR.sprite = defaultImage;
        }
        {
            
        }
    }
}
