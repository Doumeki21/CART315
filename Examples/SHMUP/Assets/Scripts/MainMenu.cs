using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource clickSound, click;
    
    public void PlayGame()
    {
        click.pitch = 1f;
        click.Play();
        SceneManager.LoadScene("Main");
    }

    public void Return()
    {
        click.pitch = 1f;
        click.Play();
        SceneManager.LoadScene("Menu");
    }
}
