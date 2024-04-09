using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource lostSFX;
    public AudioSource winSFX;
    
    // public AudioSource ConfirmSFX;

    private void Awake()
    {
        if (lostSFX != null)
        {
            lostSFX.Play();
        }
        else if (winSFX != null)
        {
            winSFX.Play();
        }
    }

    public void ButtonClicked()
    {
        AudioManager.instance.PlayButtonClickSFX(); // Assuming a button click trigger
        // Perform other button actions (e.g., scene loading)
    }

    public void Play()
    {
        SceneManager.LoadScene("Main");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Title()
    {
        SceneManager.LoadScene("Title");
    }

    public void How()
    {
        SceneManager.LoadScene("Instructions");
    }
    
}
