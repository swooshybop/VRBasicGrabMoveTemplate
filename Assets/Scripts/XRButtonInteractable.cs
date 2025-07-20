using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class XRButtonInteractable : XRSimpleInteractable
{

    [SerializeField] Image buttonImage;
    [SerializeField] Color[] buttonColors = new Color[4];

    private Color normalColor;
    private Color highlightedColor;
    private Color pressedColor;
    private Color selectedColor;

    private bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        normalColor = buttonColors[0];
        highlightedColor = buttonColors[1];
        pressedColor = buttonColors[2];
        selectedColor = buttonColors[3];

        buttonImage.color = normalColor;
        
    }

    protected override void OnHoverEntered(HoverEnterEventArgs args) //when you are just hovering over the button
    {
        base.OnHoverEntered(args);
        isPressed = false; //because when you are hovering over the button, we want it to be normal color (Only change on pressing the trigger)
        buttonImage.color = highlightedColor;
    }

    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);
        if(!isPressed)
        {
            buttonImage.color = normalColor;
        }
        
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args) //when you actually press the trigger
    {
        base.OnSelectEntered(args);
        isPressed = true; //set this to true, so when you stop hovering over the button, is stays pressed color (Changed wehen you re-hover)
        buttonImage.color = pressedColor;
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        buttonImage.color = selectedColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
