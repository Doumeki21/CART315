using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public Image Character;
    public Sprite Neutral;
    public Sprite Ok;
    public Sprite Splendid;
    public Sprite Smashn;
    public Sprite Yikes;
    
    public static CharacterManager instance; //this is a singleton!

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        Character.sprite = Neutral;
    }

    public void SwitchNeutral()
    {
        Character.sprite = Neutral;
    }

    public void SwitchOk()
    {
        Character.sprite = Ok;
    }
    
    public void SwitchSplendid()
    {
        Character.sprite = Splendid;
    }
    
    public void SwitchSmashn()
    {
        Character.sprite = Smashn;
    }
    
    public void SwitchYikes()
    {
        Character.sprite = Yikes;
    }
    
    // Update is called once per frame
    // void Update()
    // {
    //     if (gameManager.instance != null)
    //     {
    //         if (gameManager.instance.okHit())
    //         {
    //             Character.sprite = Ok;
    //         }
    //         else if (gameManager.instance.GoodHit())
    //         {
    //             Character.sprite = Splendid;
    //         }
    //         else if (gameManager.instance.PerfectHit())
    //         {
    //             Character.sprite = Smashn;
    //         }
    //         else if (gameManager.instance.MissedNote())
    //         {
    //             Character.sprite = Yikes;
    //         }
    //         else
    //         {
    //             Character.sprite = Neutral;
    //         } 
    //     }
    // }
}
