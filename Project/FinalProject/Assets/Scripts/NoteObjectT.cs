using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//check when the musical notes enter the button areas.
public class NoteObjectT : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    public KeyCode secondKey;

    private String matchSprite =""; // in collision 
    private String matchSpriteOtherWay =""; // in collision
    public String gameSprite; // set in unity

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        // if (gameObject.tag == "Single" &&  Input.GetKey(keyToPress)){

            if (gameObject.tag == "Single"){
            if(gameSprite.Equals(matchSprite)){
            
            if (canBePressed)
            {
               //Debug.Log(gameSprite);
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
            // Destroy(this);
        }

            if (gameObject.tag == "Double" && Input.GetKey(keyToPress) && Input.GetKey(secondKey)){
                //Debug.Log("keys");
                if (gameSprite.Equals(matchSprite) || gameSprite.Equals(matchSpriteOtherWay)){
            if (canBePressed)
            {

                // Debug.Log(matchSpriteOtherWay);
                // Debug.Log(matchSprite);
                // Debug.Log(gameSprite);

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
                   }//can be pressed
             } //match color
            }//match keys
            
        else if (transform.position.y < 0)
        {
            canBePressed = false;
            gameManager.instance.MissedNote();
            gameObject.SetActive(false);
            //matchSprite ="";
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        //check for the button.
        if (other.tag == "Activator" )
        {
            
        if(Input.GetKey(keyToPress)){
           //Debug.Log(other.GetComponent<ButtonController>().matcher);
 
            canBePressed = true;
         
           if (matchSprite =="")
           {
           matchSprite =other.GetComponent<ButtonControllerT>().matcher; //once the notes hit the button
           }
           else if(matchSprite.Contains("*") ==false){
           matchSpriteOtherWay =  other.GetComponent<ButtonControllerT>().matcher+ "*" + matchSprite;
           matchSprite = matchSprite+ "*"+ other.GetComponent<ButtonControllerT>().matcher;
         
            //Debug.Log(matchSprite);
            //Debug.Log(matchSpriteOtherWay);
           }
        }
        }
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
