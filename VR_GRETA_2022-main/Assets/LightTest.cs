using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTest : BaseActionnable
{
    public GameObject spotlight;
    public GameObject lightobject;
    public bool state = true;
    
    protected override void ActionInstant()
    {
        base.ActionInstant();
        if (state == true)
        {
            state = false;
            spotlight.SetActive(false);    
            lightobject.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }
        else
        {
            state = true;
            spotlight.SetActive(true);    
            lightobject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        }
        
        
    }
    
}
