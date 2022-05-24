using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Ball : MonoBehaviour
{
    public XRGrabInteractable ball;
    [SerializeField] private Light _lightComponent;
    //private bool hover = false;
    public Transform player;
    public Canvas display;

    
    
    private void Start()
    { 
        _lightComponent = gameObject.GetComponent<Light>();
    }

    private void Update()
    {
        //display.transform.LookAt(player);
    }

    private void OnEnable()
    {
        ball.hoverEntered.AddListener(behaviourBall);
        ball.hoverExited.AddListener(behaviourBallExit);
    }

    private void OnDisable()
    {
        ball.hoverEntered.RemoveListener(behaviourBall);
        ball.hoverExited.RemoveListener(behaviourBallExit);
    }

    public void behaviourBall(HoverEnterEventArgs args)
    {
        
        if (!_lightComponent.enabled)
        {
            _lightComponent.enabled=true;
        }
        
    }

    public void behaviourBallExit(HoverExitEventArgs args)
    {
        
        if (_lightComponent.enabled)
        {
            _lightComponent.enabled = false;
        }
    }
}
