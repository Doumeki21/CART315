using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{
    public Sprite redSprite;
    public Sprite blueSprite;
    public Sprite yellowSprite;

    private SpriteRenderer redButton;
    private SpriteRenderer blueButton;

    private bool redIsDefault = true;
    private bool blueIsDefault = true;

    // Start is called before the first frame update
    void Start()
    {
        // Find the red and blue buttons in the scene
        redButton = GameObject.Find("RedDefault").GetComponent<SpriteRenderer>();
        blueButton = GameObject.Find("BlueDefault").GetComponent<SpriteRenderer>();

        // Set the default sprites for the red and blue buttons
        redButton.sprite = redSprite;
        blueButton.sprite = blueSprite;
    }

    // Method to switch the color of the red button
    public void SwitchRedColor()
    {
        if (redIsDefault)
        {
            redButton.sprite = yellowSprite;
        }
        else
        {
            redButton.sprite = redSprite;
        }
        redIsDefault = !redIsDefault;
    }

    // Method to switch the color of the blue button
    public void SwitchBlueColor()
    {
        if (blueIsDefault)
        {
            blueButton.sprite = yellowSprite;
        }
        else
        {
            blueButton.sprite = blueSprite;
        }
        blueIsDefault = !blueIsDefault;
    }
}
