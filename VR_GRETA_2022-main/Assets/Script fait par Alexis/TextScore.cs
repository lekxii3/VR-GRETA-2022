using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Audio;
using UnityEngine.UI;

public class TextScore : MonoBehaviour
{
    public Text scoreBoard;
    public int score;

    public AudioSource sonBip;

    private void Start() {
        sonBip = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        Target.TargetSignalLaunch += AddScore;
    }

    private void OnDisable()
    {
        Target.TargetSignalLaunch -= AddScore;
    }


    private void AddScore()
    {
        score++;
        sonBip.Play();
        scoreBoard.text = " " + score;
        
    }
    
    /*public void Update()
    {
        throw new NotImplementedException();
    }*/
}