using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColor : MonoBehaviour
{
    public Material[] wallColorChange;
    [SerializeField] private int index = 0;
    public Renderer _renderer;
    public ScriptableObjectData dataValues;


    private void Awake()
    {
        index = dataValues.indexForWallColors;
        _renderer.material = wallColorChange[index];
    }


    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnEnable()
    {
        UIButton.uiButtonSignalLanch += ColorChange;
    }

    private void OnDisable()
    {
        UIButton.uiButtonSignalLanch -= ColorChange;
    }

    private void ColorChange()
    {
        if (index<wallColorChange.Length-1)
        {
            index++;
            _renderer.material = wallColorChange[index];
        }
        else
        {
            index = 0;
            _renderer.material = wallColorChange[index];

        }

        dataValues.indexForWallColors = index;

    }
}
