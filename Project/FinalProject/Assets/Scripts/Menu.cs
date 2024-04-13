using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource lostSFX;
    public AudioSource winSFX;
    
    public bool isPracticeMode = true;
    
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

    public void Survival()
    {
        ModeManager.isPracticeMode = false;
        SceneManager.LoadScene("Main");
    }
    public void Practice()
    {
        ModeManager.isPracticeMode = true;
        SceneManager.LoadScene("Main");
    }

    public void Play()
    {
        SceneManager.LoadScene("Modes");
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
    
    public void QuitGameButton()
    {
        QuitGame();
    }

    void QuitGame()
    {
        Application.Quit(); // Quits the game
        // Alternatively, can use SceneManager.LoadScene("QuitScene") for a dedicated quit scene
    }
    
}
