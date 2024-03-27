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
    private SpriteRenderer yellowButton;

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
        if (redButton.sprite == redSprite)
        {
            redButton.sprite = yellowSprite;
        }
        else if (redButton.sprite == yellowSprite)
        {
            redButton.sprite = redSprite;
        }
        
    }

    // Method to switch the color of the blue button
    public void SwitchBlueColor()
    {
        if (blueButton.sprite == blueSprite)
        {
            blueButton.sprite = yellowSprite;
        }
        else if (blueButton.sprite == yellowSprite)
        {
            blueButton.sprite = blueSprite;
        }
    }
}
