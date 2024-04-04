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

    public Sprite matchSprite;
    // public Sprite matchSecondSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Tracks accuracy of player input.
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

        //Cannot use GetKeyDown to check 2 keys at once!!
        if (gameObject.tag == "Double" && Input.GetKey(keyToPress) && Input.GetKey(secondKey))
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
        // Check for matching sprites (for double notes).
        SpriteRenderer otherSpriteRenderer = other.GetComponent<SpriteRenderer>();
        if (otherSpriteRenderer != null) //If the collider's GameObject doesn't have a SpriteRenderer component attached to it, GetComponent<SpriteRenderer>() will return null.
        {
            string otherSpriteName = otherSpriteRenderer.sprite.name;
            
            //check for the matching single notes.
            if (other.tag == "Activator" && gameObject.tag == "Single" && otherSpriteName == matchSprite.name)
            {
                canBePressed = true;
            }
            
            if (other.tag == "Activator" && gameObject.tag == "Double" && otherSpriteName == matchSprite.name)
            {
                canBePressed = true;
            }
            // else if (other.tag == "Activator" && gameObject.tag == "Single")
            // {
            //     canBePressed = true;
            // }
        }
        
        // //check for double notes, this = the note or obj the script is tied to.
        // if (gameObject.tag == "Double" && Input.GetKey(keyToPress) && Input.GetKey(secondKey))
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
