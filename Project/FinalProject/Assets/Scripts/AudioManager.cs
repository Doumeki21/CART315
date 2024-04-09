using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource musicSource; //Assign from scene.
    public AudioClip musicClip; // Assign your background music clip here (from assets)

    public List<string> targetSceneNames;
    public AudioSource buttonClickSFX;
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep this object alive across scenes
        }
    }

    void Start()
    {
        if (musicSource == null)
        {
            musicSource = GetComponent<AudioSource>();
        }
    
        if (musicClip != null)
        {
            musicSource.clip = musicClip;
            musicSource.Play();
        }
    }

    private void Update()
    {
        
        if (targetSceneNames.Contains(SceneManager.GetActiveScene().name))
        {
            if (!musicSource.isPlaying) // Check if music is not playing
            {
                musicSource.clip = musicClip; // Reassign the clip in case it's lost
                musicSource.Play();
            }
        }
        
        if (!targetSceneNames.Contains(SceneManager.GetActiveScene().name))
        {
            musicSource.Stop();
        }
    }
    
    //Accessed in Menu.cs
    public void PlayButtonClickSFX()
    {
        if (buttonClickSFX != null)
        {
            buttonClickSFX.Play();
        }
    }
}
