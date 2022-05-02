using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PorteTest : BaseActionnable
{
    private Vector3 _basePosition;
    private Quaternion _baseRotation;


    private void Start()
    {
        _basePosition = transform.position;
        _baseRotation = transform.rotation;
    }

    protected override void ActionContinue(Vector3 interactorPositionArgs)
    {
        base.ActionContinue(interactorPositionArgs);
        //différence entre la position actuelle du controller en Z et précédente position du controller en Z 
        float delta = 0f;
        transform.position = _basePosition;
        //transform.rotation = new Quaternion(_baseRotation.x, Mathf.Clamp(transform.rotation.y+delta,0f,-90f),_baseRotation.z,Quaternion.identity);
        
    }
}
