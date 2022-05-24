using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;
using Button = UnityEngine.UI.Button;

public class button : MonoBehaviour
{
    public XRSimpleInteractable _button;
    public LightRoom light;
    public bool lightON = true;
    public ScriptableObjectData dataValues;

    


    private void Awake()  // ici c'est pour reinitialiser les variables par rapport au ScriptableObject Data 
    {
        if (dataValues.indexLight < dataValues.light.Length - 1)
        {
            lightON = dataValues.light[dataValues.indexLight];
        }   
        
        if (dataValues.light[dataValues.indexLight])
        {
            light.Jallume();
        }
        else
        {
            light.Jeteinds();
        }
    }


    public void OnEnable()
    {
        _button.selectEntered.AddListener(Clicked);
    }

    public void OnDisable()
    {
        _button.selectExited.RemoveListener(Clicked);
    }

   public void Clicked(SelectEnterEventArgs args)
    {
        Debug.Log(dataValues.light[dataValues.indexLight]);
       
        if (dataValues.light[dataValues.indexLight])
        {
            // lightON = false;
            dataValues.light[dataValues.indexLight] = false;
            light.Jeteinds();
        }
        else
        {
            // lightON = true;
            dataValues.light[dataValues.indexLight] = true;
            light.Jallume();
        }
    }
   
   public void Clicked(SelectExitEventArgs args)
   {
       
   }



}
