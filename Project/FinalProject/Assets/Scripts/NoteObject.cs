using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//check when the musical notes enter the button areas.
public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
                // gameManager.instance.NoteHit();
                if (transform.position.y > 1.55 || transform.position.y < 0.44)
                {
                    Debug.Log("ok");
                    gameManager.instance.okHit();
                }
                else if (transform.position.y > 1.35 || transform.position.y < 0.65)
                {
                    Debug.Log("good");
                    gameManager.instance.GoodHit();
                }
                else
                {
                    Debug.Log("perfect");
                    gameManager.instance.PerfectHit();
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
            gameManager.instance.MissedNote();
        }
    }
}
