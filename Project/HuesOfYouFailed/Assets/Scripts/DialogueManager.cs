using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//code referenced: https://youtu.be/y2N_J391ptg?si=m_k4bo5bgeST1WaZ

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager _instance;
    public Text textComponent;

    private void Awake()
    {
        //if there alrdy exists a dialogue in the scene, destroy
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            //else if it's the first/ only creation of the dialogue box-
            _instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //make sure the cursor is visible to player
        Cursor.visible = true;
        //default the dialogue box not showing
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
    }

    public void ShowDialogue(string message)
    {
        //enable message
        gameObject.SetActive(true);
        textComponent.text = message;
    }
    
    public void HideDialogue()
    {
        //disable message
        gameObject.SetActive(false);
        textComponent.text = String.Empty;
    }
    
}
