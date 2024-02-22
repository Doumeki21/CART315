using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public SceneManager manager;
    public float timer = 0f;
    public float maxTimer = 8f;

    public static GameManager Instance;
    
    // Start is called before the first frame update
    void Start()
    {
        
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