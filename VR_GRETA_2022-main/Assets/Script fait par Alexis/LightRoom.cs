using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRoom : MonoBehaviour

// dire à Gilbert s'il serait pas mieux de le mettre en héritage du button


{
    public GameObject spotlight;
    public GameObject lightobject;
    

   
    
    public void Jeteinds()
    {
        
        spotlight.SetActive(false);
        lightobject.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        
    }
    
    public void Jallume()
    {
        
        spotlight.SetActive(true);
        lightobject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }
}
