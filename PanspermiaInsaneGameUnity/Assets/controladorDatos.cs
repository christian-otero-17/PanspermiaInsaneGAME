using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class controladorDatos : MonoBehaviour
{
    public GameObject jugador;
    public string archivoDeGuardado;

    public DatosJuego datosJuego = new DatosJuego();
    private void Awake()
    {
        archivoDeGuardado = Application.dataPath + "/PanspermiaInsaneGuardado.json";

        jugador = GameObject.FindGameObjectWithTag("Player");
    }

    public void CargarDatos()
    {
        if (File.Exists(archivoDeGuardado))
        {
            string contenido = File.ReadAllText(archivoDeGuardado);
            datosJuego = JsonUtility.FromJson<DatosJuego>(contenido);


            jugador.transform.position = datosJuego.posicion;
            GameManager.Instace.vidas = datosJuego.vidas;
        }
        else
        {
            Debug.Log("El archivo no existe");
        }
    }

    public void GuardarDatos()
    {
        DatosJuego nuevosDatos = new DatosJuego()
        {
            posicion = jugador.transform.position,
            vidas = GameManager.Instace.vidas,
            nivelNumero = SceneManager.GetActiveScene().buildIndex
    };
        string cadenaJSON = JsonUtility.ToJson(nuevosDatos);

        File.WriteAllText(archivoDeGuardado, cadenaJSON);
        Debug.Log("Archivo Guardado");
    }
}
