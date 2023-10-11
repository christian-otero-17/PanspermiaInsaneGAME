using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasosPiesSonido : MonoBehaviour
{
   
 public AudioSource Pie;

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {

            Pie.Play();
    }
}


   