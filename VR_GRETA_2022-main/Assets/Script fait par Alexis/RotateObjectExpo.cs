using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectExpo : MonoBehaviour
{

    private float speedRotate = 0.2f;
    
   
   private void Update() 
   {
       transform.Rotate(0,transform.position.y*speedRotate,0);
   }

   
}
