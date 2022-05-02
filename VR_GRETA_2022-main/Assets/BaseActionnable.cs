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
        interactable.selectEntered.AddListener(EnterSelect);
    }
    private void OnDisable()
    {
        interactable.selectEntered.RemoveListener(EnterSelect);
    }

    protected void EnterSelect(SelectEnterEvent args)
    {
        
    }
}
