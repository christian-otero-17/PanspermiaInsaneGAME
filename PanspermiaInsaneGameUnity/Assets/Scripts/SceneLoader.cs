using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public controladorDatos controldatos;
    public DatosJuego datos;
   // public DatosJuego datos;
    public void Level1()
    {
        SceneManager.LoadScene("Level1");

    }

    //public void CargarProgreso()
    //{
    //    //int nivel = controldatos.GuardarDatos().


    //    if(nivel ==  2)
    //    {
    //        SceneManager.LoadScene("Level1");


    //    }
    //    if (nivel == 3)
    //    {
    //        SceneManager.LoadScene("Level2");

    //    }
    //    if (nivel == 4)
    //    {
    //        SceneManager.LoadScene("Level3");

    //    }
    //}
}