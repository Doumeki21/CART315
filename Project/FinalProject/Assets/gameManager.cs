using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public int scorePerPerfectNote = 200;

    public int currentMultiplier;
    // public int multiplierTracker;
    // public int[] multiplierThresholds;
    
    public Text scoreText;
    public Text multiText;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scoreText.text = "Score: " + 0;
        currentMultiplier = 1;
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
        
        multiText.text = "x " + currentMultiplier;
        
        // currentScore += scorePerNote * currentMultiplier;
        scoreText.text = "Score: " + currentScore;
    }

    public void okHit()
    {
        currentMultiplier++;
        currentScore += scorePerNote * currentMultiplier;
        NoteHit();
    }
    
    public void GoodHit()
    {
        currentMultiplier++;
        currentScore += scorePerGoodNote * currentMultiplier;
        NoteHit();
    }
    
    public void PerfectHit()
    {
        currentMultiplier++;
        currentScore += scorePerPerfectNote * currentMultiplier;
        NoteHit();
    }

    public void MissedNote()
    {
        currentMultiplier = 1;
        multiText.text = "x " + currentMultiplier;
    }
}
