using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//code referenced: https://youtu.be/MRdQyrpflB4?si=njfCzWDSyx-6BG8L

public class ColorWheelController : MonoBehaviour
{
    public int ID;
    private Animator anim;
    private bool selected = false;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Selected()
    {
        selected = true;
    }
    
    public void Deselected()
    {
        selected = false;
    }

    public void HoverEnter()
    {
        anim.SetBool("Hover", true);
    }
    
    public void HoverExit()
    {
        anim.SetBool("Hover", false);
    }
}
