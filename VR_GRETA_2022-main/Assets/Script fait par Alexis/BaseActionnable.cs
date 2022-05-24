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
    public Transform interactorPosition;


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
            interactorPosition = args.interactorObject.transform;
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
            ActionContinue(interactorPosition.position);
        }
    }
}
