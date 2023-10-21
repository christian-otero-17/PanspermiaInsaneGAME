using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeNivel : MonoBehaviour
{
    public Transform puntoInicial;
    public GameObject personaje;
    public Transform bandera1;
    public Transform bandera2;

    void Start()
    {
        personaje = GameObject.FindGameObjectWithTag("Player");
      puntoInicial = GameObject.FindGameObjectWithTag("PuntoInicial").transform;
        MoverAPuntoInicial();
        bandera1 = GameObject.FindGameObjectWithTag("bandera1").transform;
        bandera2 = GameObject.FindGameObjectWithTag("bandera2").transform;
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

    public void MoverABandera1() {
        personaje.transform.position = bandera1.position;

    }

    public void MoverABandera2()
    {
        personaje.transform.position = bandera2.position;   
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
