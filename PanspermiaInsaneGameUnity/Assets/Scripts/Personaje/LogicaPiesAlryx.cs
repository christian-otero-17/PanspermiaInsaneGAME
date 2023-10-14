using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPiesAlryx : MonoBehaviour
{
    public MovimientoAlryxEscenario logicaAlryx;

    private void OnTriggerStay(Collider other)
    {
        logicaAlryx.puedoSaltar = true;
    }
    private void OnTriggerExit(Collider other)
    {
        logicaAlryx.puedoSaltar = false;
    }
}
