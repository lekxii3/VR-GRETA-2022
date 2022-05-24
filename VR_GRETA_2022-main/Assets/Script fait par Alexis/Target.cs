using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public delegate void TargetSignal();
    public static event TargetSignal TargetSignalLaunch;


    private void  OnCollisionEnter(Collision other)        
    {
        if(other.gameObject){
            TargetSignalLaunch?.Invoke();            
        }
    }
}
