using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//audio generated from: https://sfbgames.itch.io/chiptone

public class LivesScript : MonoBehaviour
{
    public Text lifeText;
    public int lives;
    public AudioSource lifeSound, hurt;

    public static LivesScript S;
    
    // Start is called before the first frame update
    void Start()
    {
        lives = 6;
        UpdateLife();
    }

    //track when enemies or enemy bullets hit player. 
    public void UpdateLife()
    {
        lives -= 1;
        hurt.pitch = 1f;
        hurt.Play();
        string lifeDisplay = "Life: " + lives.ToString();
        lifeText.text = lifeDisplay;

        if (lives <= 0)
        {
            GameManager.Instance.GameOver();
            hurt.pitch = 1f;
            hurt.Play();
        }
    }
}
