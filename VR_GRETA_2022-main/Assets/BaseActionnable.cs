using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BaseActionnable : MonoBehaviour
{
    public XRSimpleInteractable interactable;
    public bool actionInstantannee = true;
    public bool isSelected = false;
    public Vector3 interactorPosition;


    private void OnEnable()
    {
        interactable.selectEntered.AddListener(StartSelect);
        interactable.selectExited.AddListener(StopSelect);
    }
    private void OnDisable()
    {
        interactable.selectEntered.RemoveListener(StartSelect);
        interactable.selectExited.RemoveListener(StopSelect);
    }

    protected void StartSelect(SelectEnterEventArgs args)
    {
        if (!actionInstantannee)
        {
            isSelected = true;
            interactorPosition = args.interactorObject.transform.position;
        }
        else
        {
            ActionInstant();
        }
    }

    protected void StopSelect(SelectExitEventArgs args)
    {
        if (!actionInstantannee)
        {
            isSelected = false;
            interactorPosition = Vector3.zero;
        }
    }

    protected virtual void ActionInstant()
    {
        // script light
    }

    protected virtual void ActionContinue(Vector3 interactorPositionArgs)
    {
        // script tiroir 
    }

    private void Update()
    {
        if (isSelected)
        {
            ActionContinue(interactorPosition);
        }
    }
}
