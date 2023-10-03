using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaVacio : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<MovimientoAlryxEscenario>().SendMessage("RecolocarPersonaje");

    }
}
