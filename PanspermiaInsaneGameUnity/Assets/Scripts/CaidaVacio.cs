using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaVacio : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
      
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instace.perderVida(1);
            FindObjectOfType<MovimientoAlryxEscenario>().SendMessage("RecolocarPersonaje");


        }

    }
}
 