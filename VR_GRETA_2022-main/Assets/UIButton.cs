using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    public delegate void uiButtonSignal();

    public static event uiButtonSignal uiButtonSignalLanch;

    public void TestClic()
    {
      uiButtonSignalLanch?.Invoke();   
    }
}
