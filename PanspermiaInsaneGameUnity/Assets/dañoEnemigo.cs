using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dañoEnemigo : MonoBehaviour
{
    public int contadorBalazos;
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Bala"))
        {
            contadorBalazos++;

            if(contadorBalazos > 5)
            {
                Destroy(gameObject);
            }

        }
    }
}
