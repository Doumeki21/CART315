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

  //is single?
    if (gameObject.tag == "Single"){
        //do we have a match + collide? - (the match sprite WILL only be correct here...)
        if(gameSprite.Equals(matchSprite)){
            Debug.Log("matched");
           
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
        else if (transform.position.y < 0)
        {
            //canBePressed = false;
            gameManager.instance.MissedNote();
            gameObject.SetActive(false);
            //matchSprite ="";
        }
            // Destroy(this);
        }//single

        

             if (gameObject.tag == "Double" ){
                   // Debug.Log("correct keys");
                    
                    if (gameSprite.Equals(matchSprite) || gameSprite.Equals(matchSpriteOtherWay)){
                    
                    Debug.Log("double match");
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

                    }//match
            //or here
            else if (transform.position.y < 0)
            {
                //canBePressed = false;
                gameManager.instance.MissedNote();
                gameObject.SetActive(false);
                //matchSprite ="";
            }
     }//double
    }//update

    private void OnTriggerStay2D(Collider2D other)
    {
       
        //check for collision with button.
        if (other.tag == "Activator" )
        {
        
        //are we pressing the right key?
        if(gameObject.tag == "Single" && Input.GetKey(keyToPress)){
         
         //check for match
           if(matchSprite ==""){
              matchSprite =other.GetComponent<ButtonControllerT>().matcher; //once the notes hit the button
         }

        } //SINGLE CASE


/*** CHECK FOR DOUBLE **/
        if(gameObject.tag == "Double" && (Input.GetKey(keyToPress) && Input.GetKey(secondKey))){
             if(matchSprite ==""){
              matchSprite =other.GetComponent<ButtonControllerT>().matcher; //once the notes hit the button
         }
          // //check for double
           else if(matchSprite.Contains("*") ==false){
           matchSpriteOtherWay =  other.GetComponent<ButtonControllerT>().matcher+ "*" + matchSprite;
           matchSprite = matchSprite+ "*"+ other.GetComponent<ButtonControllerT>().matcher;
         
           }

        } //DOUBLE
        
    }//trigger activator
}
    
    // private void OnTriggerExit2D(Collider2D other)
    // {
    //     if (other.tag == "Activator")
    //     {
    //         canBePressed = false;
    //         gameManager.instance.MissedNote();
    //     }
   
}

