using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpoBecomesVisible : MonoBehaviour
{
    public GameObject[] objectsExpo;
    private bool currentButton = false;

    private void OnEnable() 
    {
        UIButton.uiButtonSignalLanchExpo += BecomesVisible;
    }

    private void OnDisable() 
    {
        UIButton.uiButtonSignalLanchExpo -= BecomesVisible;
    }

    private void BecomesVisible()
   {
       if(currentButton == false)
       {
            currentButton = true;
            
           foreach(GameObject objectsExpo in objectsExpo)
           {
               objectsExpo.SetActive(true);
           }
       }
       else
       {    
           currentButton = false;
           
           foreach(GameObject objectsExpo in objectsExpo)
           {
               objectsExpo.SetActive(false);
           }
       }
       
   }





    /*  for (int i = 0; i < objectsExpo.Length-1; i++)
            {                
                
                gameObject.SetActive(false);
            }   */









}
