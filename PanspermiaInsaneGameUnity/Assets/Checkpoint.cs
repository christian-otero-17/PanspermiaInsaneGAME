using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform puntoInicial;
    public Transform posAlryx;

    private void Start()
    {
        puntoInicial = GameObject.FindGameObjectWithTag("PuntoInicial").transform;
    }
    private void OnTriggerEnter(Collider other) { 
        
    if (other.CompareTag("Player"))
        {
            posAlryx = GameObject.FindGameObjectWithTag("Player").transform;

            puntoInicial.position = posAlryx.position;
            Debug.Log("CAMBIO LA APARICION");
        }
    }
}
    
