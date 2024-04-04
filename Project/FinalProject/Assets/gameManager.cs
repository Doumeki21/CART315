using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//control when the music plays
public class gameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller theBS;

    public static gameManager instance;

    public int currentScore;
    public int scorePerNote = 100;
    public int scorePerGoodNote = 150;
    public int scorePerPerfectNote = 250;

    public int currentMultiplier;
    // public int multiplierTracker;
    // public int[] multiplierThresholds;
    
    public Text scoreText;
    public Text multiText;
    public Text accuracyText;
    

    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }
    public void GameOver()
    {
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scoreText.text = "0";
        currentMultiplier = 0;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;
                
                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
        // if (currentMultiplier - 1 < multiplierThresholds.Length)
        // {
        //     multiplierTracker++; //check if they have passed the thresholds.
        //     if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
        //     {
        //         multiplierTracker = 0;
        //         currentMultiplier++;
        //     }
        // }
        
        // multiText.text = "x " + currentMultiplier;
        multiText.text = "" + currentMultiplier;
        
        // currentScore += scorePerNote * currentMultiplier;
        // scoreText.text = "Score: " + currentScore;
        scoreText.text = "" + currentScore;
    }

    public void okHit()
    {
        Debug.Log("ok");

        currentMultiplier++;
        currentScore += scorePerNote * currentMultiplier;
        accuracyText.text = "OK";
        NoteHit();
    }
    
    public void GoodHit()
    {
        currentMultiplier++;
        currentScore += scorePerGoodNote * currentMultiplier;
        accuracyText.text = "DANDY";
        NoteHit();
    }
    
    public void PerfectHit()
    {
        Debug.Log("perfect");
        currentMultiplier++;
        currentScore += scorePerPerfectNote * currentMultiplier;
        accuracyText.text = "SMASHIN'!";
        NoteHit();
    }

    public void MissedNote()
    {
        Debug.Log("missed");
        currentMultiplier = 0;
        multiText.text = "" + currentMultiplier;
        accuracyText.text = "YIKES";

        currentHealth = currentHealth - 15;
        // multiText.text = "x " + currentMultiplier;
    }
}
