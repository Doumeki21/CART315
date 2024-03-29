using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{

    public Color defaultColor = new Color(0.96f, 0.84f, 0.12f);  // Default color (#F6D51F)
    public Color switchRed = new Color(0.83f, 0.16f, 0.50f); 
    public Color switchBlue = new Color(0.18f, 0.49f, 0.82f);

    private SpriteRenderer SRC;
    private Color currentColorD;
    private Color currentColorH;
    // private bool isSwitched = false;

    // Start is called before the first frame update
    void Start()
    {
        SRC = GetComponent<SpriteRenderer>();
        currentColorD = defaultColor;
        currentColorH = defaultColor;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if switch key is pressed
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (gameObject.name == "switchL")
            {
                if (currentColorD == defaultColor)
                {
                    currentColorD = switchRed;
                    SRC.color = currentColorD;
                }
                else if (currentColorD == switchRed)
                {
                    currentColorD = defaultColor;
                    SRC.color = currentColorD;
                }
            }
        }
        
        // Check if switch key is pressed
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (gameObject.name == "switchR")
            {
                if (currentColorH == defaultColor)
                {
                    currentColorH = switchBlue;
                    SRC.color = currentColorH;
                }
                else if (currentColorH == switchBlue)
                {
                    currentColorH = defaultColor;
                    SRC.color = currentColorH;
                }
            }
        }
    }
}
