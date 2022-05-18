using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : BaseActionnable
{
    private Quaternion doorRotation;
    private Vector3 doorPosition;
    private Vector3 worldPosition;
    private Vector3 lastPositionController;
    
    private float delta;

    private void Start()
    {
        doorPosition = transform.position;
        doorRotation = transform.rotation;
    }

    protected override void ActionContinue(Vector3 interactorPositionArgs)
    {
        base.ActionContinue(interactorPositionArgs);
        
        transform.position = doorPosition;

        if (lastPositionController == new Vector3(0,0,0))
        {
            lastPositionController = interactorPositionArgs;
        }

        Vector3 DC1 = interactorPositionArgs - doorPosition;
        Vector3 DC2 = lastPositionController - doorPosition;
        
        delta = Vector3.SignedAngle(DC1, DC2, Vector3.up);
        
        transform.rotation = Quaternion.Euler(doorRotation.eulerAngles.x, doorRotation.eulerAngles.y + delta, doorRotation.eulerAngles.z);
        

        lastPositionController = interactorPositionArgs;
    }
}
