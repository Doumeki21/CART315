using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{

    public Color switchYellow = new Color(0.96f, 0.84f, 0.12f);  // Default color (#F6D51F)
    public Color switchRed = new Color(0.83f, 0.16f, 0.50f); 
    public Color switchBlue = new Color(0.18f, 0.49f, 0.82f);

    private SpriteRenderer SRC;
    private Color currentColorD;
    private Color currentColorH;

    private Color currentActiveColorL;
    private Color currentActiveColorR;
    // Start is called before the first frame update
    void Start()
    {
        SRC = GetComponent<SpriteRenderer>();
        currentColorD = switchYellow;
        currentColorH = switchYellow;
        currentActiveColorL = switchRed;
        currentActiveColorR = switchBlue;

    }

    // Update is called once per frame
    void Update()
    {
        // Check if switch key is pressed
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (gameObject.name == "switchL")
            {
                if (currentColorD == switchYellow)
                {
                    currentColorD = switchRed;
                    SRC.color = currentColorD;
                }
                else if (currentColorD == switchRed)
                {
                    currentColorD = switchYellow;
                    SRC.color = currentColorD;
                }
            }

            if (gameObject.name == "switchActiveL")
            {
                if (currentActiveColorL == switchRed)
                {
                    currentActiveColorL = switchYellow;
                    SRC.color = currentActiveColorL;
                }
                else if (currentActiveColorL == switchYellow)
                {
                    currentActiveColorL = switchRed;
                    SRC.color = currentActiveColorL;
                }
            }
        }
        
        // Check if switch key is pressed
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (gameObject.name == "switchR")
            {
                if (currentColorH == switchYellow)
                {
                    currentColorH = switchBlue;
                    SRC.color = currentColorH;
                }
                else if (currentColorH == switchBlue)
                {
                    currentColorH = switchYellow;
                    SRC.color = currentColorH;
                }
            }

            if (gameObject.name == "switchActiveR")
            {
                if (currentActiveColorR == switchBlue)
                {
                    currentActiveColorR = switchYellow;
                    SRC.color = currentActiveColorR;
                }
                else if (currentActiveColorR == switchYellow)
                {
                    currentActiveColorR = switchBlue;
                    SRC.color = currentActiveColorR;
                }
            }
        }
    }
}
