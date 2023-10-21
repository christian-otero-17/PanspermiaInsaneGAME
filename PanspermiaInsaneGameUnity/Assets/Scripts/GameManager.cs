using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Text municionTexto;
    public Text vidaTexto;
    public Text partesTexto;
    public Text tiempoTexto;
    public TomarArmas tomararmas;
    

    public static GameManager Instace { get; private set; }

    public int armaMunicion;
    public int partesNave;
    public int vidas = 2;
    public float tiempo;
    public float tiempoAux = 0.0f;
 


    public void Awake()
    {
        Instace = this; 
    }

    // Update is called once per frame
    void Update()
    {
        municionTexto.text = armaMunicion.ToString();
        vidaTexto.text = vidas.ToString();
        partesTexto.text = partesNave.ToString();
        tiempoTexto.text = tiempo.ToString();
    }
    public void FuegoMuerte()
    {
        vidas = vidas - 1;
        checaVida();
    }

    public void perderVida(int reducirVida)
    {
        vidas -= reducirVida;
        tomararmas.desactivarArmas();
        checaVida();
    }
    public void ganarVida(int subirVida)
    {
        vidas += subirVida;
        checaVida();
    }


    public void tomarParte(int parteNavetomada)
    {
        partesNave += parteNavetomada;
    }


    //public  void timer()
    //{
    //    tiempo -= Time.deltaTime;

    //    tiempoTexto.text = "" + tiempo.ToString("f1");

    //}

    public void checaVida()
    {
        if(vidas <= 0)
        {
           vidas = 5;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}