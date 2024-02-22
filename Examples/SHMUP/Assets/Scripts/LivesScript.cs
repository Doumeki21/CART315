using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesScript : MonoBehaviour
{
    public Text lifeText;
    public int lives;

    public static LivesScript S;
    
    // void Awake()
    // {
    //     S = this;
    // }
    // Start is called before the first frame update
    void Start()
    {
        lives = 4;
        UpdateLife();
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if(Input.GetKeyDown(KeyCode.Space))
    //     {
    //         UpdateLife();
    //     }
    // }
    void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.tag == "Player" && other.tag == "Enemy")
        // {
        //     UpdateLife();
        // }
        // else if (other.tag == "Player" && other.tag == "EnemyBullet")
        // {
        //     UpdateLife();
        // }
        
    }

    //track when enemies or enemy bullets hit player. 
    public void UpdateLife()
    {
        lives -= 1;
        string lifeDisplay = "Life: " + lives.ToString();
        lifeText.text = lifeDisplay;

        if (lives <= 0)
        {
            GameManager.Instance.GameOver();
        }
    }
}
