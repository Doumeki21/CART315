using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//check when the musical notes enter the button areas.
public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    public KeyCode secondKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Single" && Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
                // gameManager.instance.NoteHit();
                if (transform.position.y > 1.55 || transform.position.y < 0.44)
                {
                    gameManager.instance.okHit();
                    // gameObject.SetActive(false);
                }
                else if (transform.position.y > 1.35 || transform.position.y < 0.65)
                {
                    // Debug.Log("good");
                    gameManager.instance.GoodHit();
                    // gameObject.SetActive(false);
                }
                else
                {
                    gameManager.instance.PerfectHit();
                    // gameObject.SetActive(false);
                }
            }
            // Destroy(this);
        }

        if (gameObject.tag == "Double" && Input.GetKeyDown(keyToPress) && Input.GetKeyDown(secondKey))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
                // gameManager.instance.NoteHit();
                if (transform.position.y > 1.55 || transform.position.y < 0.44)
                {
                    gameManager.instance.okHit();
                    // gameObject.SetActive(false);
                }
                else if (transform.position.y > 1.35 || transform.position.y < 0.65)
                {
                    // Debug.Log("good");
                    gameManager.instance.GoodHit();
                    // gameObject.SetActive(false);
                }
                else
                {
                    gameManager.instance.PerfectHit();
                    // gameObject.SetActive(false);
                }
            }
        }
        
        else if (transform.position.y < 0)
        {
            canBePressed = false;
            gameManager.instance.MissedNote();
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //check for the button.
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
        // //check for double notes, this = the note or obj the script is tied to.
        // if (tag == "Double" && Input.GetKeyDown(keyToPress) && Input.GetKeyDown(secondKey))
        // {
        //     canBePressed = true;
        // }
        
        
        // //check for double notes, this = the note or obj the script is tied to.
        // if (this.tag("Double") && Input.GetKeyDown(keyToPress) && Input.GetKeyDown(secondKey))
        // {
        //     canBePressed = true;
        // }
    }
    
    // private void OnTriggerExit2D(Collider2D other)
    // {
    //     if (other.tag == "Activator")
    //     {
    //         canBePressed = false;
    //         gameManager.instance.MissedNote();
    //     }
    // }
}
