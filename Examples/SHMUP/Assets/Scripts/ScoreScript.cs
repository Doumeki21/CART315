using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public int score;

    public static ScoreScript S;

    void Awake()
    {
        S = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            UpdateScore();
        }
    }

    //update score is reusable here to track when bullets hit enemies. 
    public void UpdateScore()
    {
        score += 1;
        string scoreDisplay = "Score: " + score.ToString();
        scoreText.text = scoreDisplay;
    }
}