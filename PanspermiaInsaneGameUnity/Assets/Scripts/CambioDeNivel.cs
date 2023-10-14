using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeNivel : MonoBehaviour
{
    public Transform puntoInicial;
    public GameObject personaje;

    void Start()
    {
        personaje = GameObject.FindGameObjectWithTag("Player");
        puntoInicial = GameObject.FindGameObjectWithTag("PuntoInicial").transform;
        MoverAPuntoInicial();
    }

    // Update is called once per frame
    void Update()
    {
        ProbarCambioDeEscena();
    }

    public void MoverAPuntoInicial()
    {
        personaje.transform.position = puntoInicial.position;
    }

    public void ProbarCambioDeEscena()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2 || SceneManager.GetActiveScene().buildIndex == 3 || SceneManager.GetActiveScene().buildIndex == 4)
        {
            if (Input.GetKey(KeyCode.Keypad1))
            {
                SceneManager.LoadScene(2);
            }
            else if (Input.GetKey(KeyCode.Keypad2))
            {
                SceneManager.LoadScene(3);
            }
            else if (Input.GetKey(KeyCode.Keypad3))
            {
                SceneManager.LoadScene(4);
            }
        }


    }
}
