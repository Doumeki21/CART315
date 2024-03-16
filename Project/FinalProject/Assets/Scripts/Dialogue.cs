using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code ref:https://youtu.be/y2N_J391ptg?si=X-E5_Ge3Wf4sA_Ez

public class Dialogue : MonoBehaviour
{
    //tweaked from the inspector
    public string message;

    private void OnMouseEnter()
    {
        DialogueManager._instance.ShowDialogue(message);
    }

    private void OnMouseExit()
    {
        DialogueManager._instance.HideDialogue();
    }
}
