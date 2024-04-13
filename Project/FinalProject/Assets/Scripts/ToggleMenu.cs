using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMenu : MonoBehaviour
{
    public GameObject ColorGuide;
    private bool isMenuVisible = true; // Flag to track menu visibility
    // Start is called before the first frame update
    void Start()
    {
        ColorGuide.SetActive(isMenuVisible);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Check for spacebar press
        {
            isMenuVisible = !isMenuVisible; // Toggle visibility flag
            ColorGuide.SetActive(isMenuVisible); // Update menu visibility
        }
    }
}
