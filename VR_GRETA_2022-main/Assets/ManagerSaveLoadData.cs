using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ManagerSaveLoadData : MonoBehaviour
{

    public ScriptableObjectData dataValues;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveToJson();
        }
        if(Input.GetKeyDown (KeyCode.L))
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
        string data = System.IO.File.ReadAllText(filePath);

        dataValues = JsonUtility.FromJson<ScriptableObjectData>(data);
        Debug.Log("load effectué");
    }
}
