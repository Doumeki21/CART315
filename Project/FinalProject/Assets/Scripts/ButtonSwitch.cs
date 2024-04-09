using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitch : MonoBehaviour
{
    public Image ButtonImage;
    public Sprite DefaultSprite;
    public Sprite HoverSprite;

    public AudioSource HoverSFX;

    private void Start()
    {
        ButtonImage.sprite = DefaultSprite;  // Set default sprite on start
    }

    public void OnMouseEnter()
    {
        HoverSFX.Play();
        ButtonImage.sprite = HoverSprite;
    }

    public void OnMouseExit()
    {
        ButtonImage.sprite = DefaultSprite;
    }
}
