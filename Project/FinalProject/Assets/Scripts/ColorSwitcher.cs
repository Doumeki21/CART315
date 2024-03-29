using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{

    public Color defaultColor;
    public Color switchColor;
    public KeyCode switchKey;

    private SpriteRenderer SRC;
    private Color currentColor;
    // private bool isSwitched = false;

    // Start is called before the first frame update
    void Start()
    {
        SRC = GetComponent<SpriteRenderer>();
        currentColor = defaultColor;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if switch key is pressed
        if (Input.GetKeyDown(switchKey))
        {
            if (gameObject.name == "switchL" || gameObject.name == "switchR")
            {
                if (currentColor == defaultColor)
                {
                    currentColor = switchColor;
                    SRC.color = currentColor;
                }
                else
                {
                    currentColor = defaultColor;
                    SRC.color = currentColor;
                }
            }
        }
    }
    // public Sprite redSprite;
    // public Sprite blueSprite;
    // public Sprite yellowSprite;
    //
    // private SpriteRenderer redButton;
    // private SpriteRenderer blueButton;
    //
    // private bool redIsDefault = true;
    // private bool blueIsDefault = true;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     // Find the red and blue buttons in the scene
    //     redButton = GameObject.Find("RedDefault").GetComponent<SpriteRenderer>();
    //     blueButton = GameObject.Find("BlueDefault").GetComponent<SpriteRenderer>();
    //
    //     // Set the default sprites for the red and blue buttons
    //     redButton.sprite = redSprite;
    //     blueButton.sprite = blueSprite;
    // }
    //
    // // Method to switch the color of the red button
    // public void SwitchRedColor()
    // {
    //     if (redIsDefault)
    //     {
    //         redButton.sprite = yellowSprite;
    //     }
    //     else
    //     {
    //         redButton.sprite = redSprite;
    //     }
    //     redIsDefault = !redIsDefault;
    // }
    //
    // // Method to switch the color of the blue button
    // public void SwitchBlueColor()
    // {
    //     if (blueIsDefault)
    //     {
    //         blueButton.sprite = yellowSprite;
    //     }
    //     else
    //     {
    //         blueButton.sprite = blueSprite;
    //     }
    //     blueIsDefault = !blueIsDefault;
    // }
}
