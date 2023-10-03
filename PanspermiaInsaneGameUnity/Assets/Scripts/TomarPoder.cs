using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomarPoder : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Power" && other.GetComponent<LogicaPowers>().destruirAutomatico == true)
        {
            other.GetComponent<LogicaPowers>().Efecto();
            Destroy(other.gameObject);
        }
    }
}
