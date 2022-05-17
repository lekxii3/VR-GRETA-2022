using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/DataForVRGreta")]
public class ScriptableObjectData : ScriptableObject
{
    public bool[] light;
    public int indexLight = 0; // index pour script button
    public int indexLight1 = 1; // index pour script LightRooms spotlight
    public int indexForWallColors = 0;
   
}
