using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Tiroir : MonoBehaviour
{
  public GameObject tiroir;

  public XRSimpleInteractable poignet;

  public bool tiroirLinked = false;
  public Transform poignee;
  

  public void Update()
  {
    transform.position = new Vector3(0f, 0f, -0f);
  }

  //public void OnEnable()
  //{
    //poignet.selectEntered.AddListener(TiroirPressed);
    //poignet.selectExited.AddListener(TiroirReleased);
  //}

  //public void OnDisable()
  //{
    //poignet.selectEntered.RemoveListener(TiroirPressed);
   // poignet.selectExited.RemoveListener(TiroirReleased);
  //}



  public void TiroirPressed(SelectEnterEventArgs args)
  {
    if (tiroirLinked)
    {
      tiroirLinked = true;
    }

    // TiroirLinked = true
    // je tiens le tiroir et le tiroir suit la main 
    // le tiroir est freeze en rotation et bouge seulement sur un seul axe Z de son propre Transform 
  }

  public void TiroirReleased(SelectExitEventArgs args)
  {
    
    // je lache le tiroir et le tiroir ne suit plus la main 
  }
  
  
  
}
