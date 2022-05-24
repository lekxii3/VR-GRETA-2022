using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.InputSystem;


public class ManagerSaveLoadData : MonoBehaviour
{

    public ScriptableObjectData dataValues;
    private void Update()
    {
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            SaveToJson();
        }
        if(Keyboard.current.lKey.wasPressedThisFrame)
        {
            LoadFromJson();
        }
    }

    private void SaveToJson()
    {
        string data = JsonUtility.ToJson((dataValues));
        string filePath = Application.persistentDataPath + "/DataValues.json";
        Debug.Log(filePath);
        System.IO.File.WriteAllText(filePath, data);
        Debug.Log("svg effectué");
    }

    private void LoadFromJson()
    {
        string filePath = Application.persistentDataPath + "/DataValues.json";
        
        Debug.Log(filePath);
        if (File.Exists(filePath))
        {
            string data = System.IO.File.ReadAllText(filePath);
            JsonUtility.FromJsonOverwrite(data, dataValues);

        }
        else
        {
            print("fichier n'existe pas");
        }
    }
}
