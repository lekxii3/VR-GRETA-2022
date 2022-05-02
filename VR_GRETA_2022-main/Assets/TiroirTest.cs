using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroirTest : BaseActionnable
{
   private Vector3 _basePosition;
   private Quaternion _baseRotation;
   private float positionControllerInstantT;
  


   private void Start()
   {
      _basePosition = transform.position;
      _baseRotation = transform.rotation;
   }

   protected override void ActionContinue(Vector3 interactorPositionArgs)
   {
      base.ActionContinue(interactorPositionArgs);
      if (positionControllerInstantT == 0)
      {
         positionControllerInstantT = interactorPositionArgs.z;
      }
      
      //différence entre la position actuelle du controller en Z et précédente position du controller en Z 
      float delta = Mathf.Clamp(interactorPositionArgs.z-positionControllerInstantT, -0.01f, 0.01f);
      positionControllerInstantT = interactorPositionArgs.z;
      transform.rotation = _baseRotation;
      transform.position = new Vector3(_basePosition.x, _basePosition.y, Mathf.Clamp(transform.position.z+delta, -1.17f, -0.608f));
      
   }
}
