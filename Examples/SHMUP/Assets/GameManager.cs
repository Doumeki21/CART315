using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public SceneManager manager;
    public float timer = 0f;
    public float maxTimer = 8f;

    public LivesScript livesScript;
    public ScoreScript scoreScript;
    public float endTimer = 27f;

    public static GameManager Instance;

    private void Awake()
    {
        //everything should reference this manager.
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //CALL THIS FUNCTION ONCE THE TIME REACHES THE END TIMER.
        Invoke("EndGame", endTimer);
    }

    public void EndGame()
    {
        SceneManager.LoadScene("EndGame");
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");

        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // //TEST: press 0 to go to gameover screen 
        // if (Input.GetKeyDown(KeyCode.Alpha0))
        // {
        //     SceneManager.LoadScene("GameOver");
        // }
      
    }
}