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
    
    public Text scoreText;
    public Text multiText;
    public Text accuracyText;
    
    private Coroutine changeSpriteRoutine;
    // public Menu manager; //To access the menu manager script when start game (title screen), paused, complete level, or when you lose.
    
    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }
    //Go to gameover screen once you lose all health.
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scoreText.text = "0";
        currentMultiplier = 0;
        // currentHealth = maxHealth;
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
    
    //Chara returns neutral after 1 second.
    IEnumerator ChangeSpriteToNeutral()
    {
        yield return new WaitForSeconds(1.0f);  // Wait for 1 second
        CharacterManager.instance.SwitchNeutral();
        // if (HealthManager.instance.currentHealth <= 50f)
        // {
        //     CharacterManager.instance.SwitchYikes();
        // }
        // else
        // {
        //     CharacterManager.instance.SwitchNeutral();
        // }
    }

    public void okHit()
    {
        Debug.Log("ok");

        currentMultiplier++;
        currentScore += scorePerNote * currentMultiplier;
        accuracyText.text = "OK";
        NoteHit();
        CharacterManager.instance.SwitchOk();
        
        if (changeSpriteRoutine != null)
        {
            StopCoroutine(changeSpriteRoutine);  // Stop any existing coroutine
        }
        changeSpriteRoutine = StartCoroutine(ChangeSpriteToNeutral());  // Start a new coroutine
    }
    
    public void GoodHit()
    {
        currentMultiplier++;
        currentScore += scorePerGoodNote * currentMultiplier;
        accuracyText.text = "DANDY";
        NoteHit();
        CharacterManager.instance.SwitchSplendid();
        
        if (changeSpriteRoutine != null)
        {
            StopCoroutine(changeSpriteRoutine);  // Stop any existing coroutine
        }
        changeSpriteRoutine = StartCoroutine(ChangeSpriteToNeutral());  // Start a new coroutine
    }
    
    public void PerfectHit()
    {
        Debug.Log("perfect");
        currentMultiplier++;
        currentScore += scorePerPerfectNote * currentMultiplier;
        accuracyText.text = "SMASHIN'!";
        NoteHit();
        CharacterManager.instance.SwitchSmashn();
        
        if (changeSpriteRoutine != null)
        {
            StopCoroutine(changeSpriteRoutine);  // Stop any existing coroutine
        }
        changeSpriteRoutine = StartCoroutine(ChangeSpriteToNeutral());  // Start a new coroutine
    }

    public void MissedNote()
    {
        Debug.Log("missed");
        currentMultiplier = 0;
        multiText.text = "" + currentMultiplier;
        accuracyText.text = "YIKES";
        HealthManager.instance.TakeDamage(10); //Calls back to health manager. 
        CharacterManager.instance.SwitchYikes();
        
        if (changeSpriteRoutine != null)
        {
            StopCoroutine(changeSpriteRoutine);  // Stop any existing coroutine
        }
        changeSpriteRoutine = StartCoroutine(ChangeSpriteToNeutral());  // Start a new coroutine

        // currentHealth = currentHealth - 15;
        // multiText.text = "x " + currentMultiplier;
    }
}
