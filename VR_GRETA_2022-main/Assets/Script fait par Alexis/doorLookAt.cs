using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class doorLookAt : BaseActionnable
{
   
    private Vector3 positionDoor;
    public Transform controller;


    private void Start()
    {
       
        
    }

    protected override void ActionContinue(Vector3 interactorPositionArgs)
    {
        base.ActionContinue(interactorPositionArgs);
        gameObject.transform.position = transform.position;
        Vector3 target = new Vector3(controller.position.x, transform.position.y, controller.position.z);
        //gameObject.transform.rotation = new Quaternion(transform.rotation.x, transform.LookAt(controller, Vector3.up), transform.rotation.z,transform.rotation.w);
        transform.LookAt(target);
        Debug.DrawRay(transform.position,target,Color.green);
        


    }
}
