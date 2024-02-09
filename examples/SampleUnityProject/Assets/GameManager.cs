using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int points;

    // singleton method
    public static GameManager S;


    // Awake should be called before Start
    void Awake()
    {
        S = this;
    }

    void Start()
    {
        lives = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loseLife() {
        lives -= 1;
    }

    public void AddPoint(int numPoints) {
        points += numPoints;
    }
}
