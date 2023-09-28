using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomarArmas : MonoBehaviour
{
    public GameObject armaActivar;
    public Animator animaciones;
    public bool estoyarmado;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {           
            armaActivar.SetActive(true);
            gameObject.SetActive(false);
            animaciones.SetBool("Arma", true);
            estoyarmado = true;
        }
    }
}