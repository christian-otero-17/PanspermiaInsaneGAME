using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update() {
        
    }

    public void Exit() {
        Debug.Log("**********JUEGO FINALIZADO**********");
           Application.Quit();
    }
}
