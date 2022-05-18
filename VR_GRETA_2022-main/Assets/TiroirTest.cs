using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TiroirTest : BaseActionnable
{
   private Quaternion rotationTiroir;
   private Vector3 positionTiroir;
   private float lastPositionController;
   private float delta;

   private void Start()
   {
       rotationTiroir = transform.rotation ; 
       positionTiroir = transform.position;
   }

   protected override void ActionContinue(Vector3 interactorPositionArgs)
   {
      base.ActionContinue(interactorPositionArgs);
      Debug.Log("testtiroir");
      transform.rotation = rotationTiroir;
      
      if (lastPositionController == 0f)
      {
          lastPositionController = interactorPositionArgs.z;
      }

      delta = Mathf.Clamp(interactorPositionArgs.z - lastPositionController,-0.01f,0.01f);

      transform.position = new Vector3(positionTiroir.x, positionTiroir.y, Mathf.Clamp(transform.position.z+delta,positionTiroir.z-0.6f,positionTiroir.z));

      lastPositionController = interactorPositionArgs.z;
   }
}
