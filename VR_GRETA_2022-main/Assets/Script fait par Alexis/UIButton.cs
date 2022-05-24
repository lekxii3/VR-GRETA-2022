using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    public delegate void uiButtonSignal();

    public static event uiButtonSignal uiButtonSignalLanch;

    public static event uiButtonSignal uiButtonSignalLanchExpo;

    public void TestClic()
    {
      uiButtonSignalLanch?.Invoke();   
    }

    public void ClicExpo()
    { 
      
      uiButtonSignalLanchExpo?.Invoke();
    }

}
