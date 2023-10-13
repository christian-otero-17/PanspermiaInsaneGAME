using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text municionTexto;
    public Text vidaTexto;

    public static GameManager Instace { get; private set; }

    public int armaMunicion = 0;

    public int vidas = 5;

    public void Awake()
    {
        Instace = this; 
    }

    // Update is called once per frame
    void Update()
    {
        municionTexto.text = armaMunicion.ToString();
        vidaTexto.text = vidas.ToString();
    }
}