using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPowers : MonoBehaviour
{
    public bool destruirConCursor;
    public bool destruirAutomatico;
    public MovimientoAlryxEscenario movimientoAlryx;

    public int tipo;
    //1 = Super Salto
    //2 = Campo Fuerza

    void Start()
    {
        movimientoAlryx = GameObject.FindGameObjectWithTag("Player").GetComponent<MovimientoAlryxEscenario>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Efecto()
    {
        switch (tipo)
        {
            case 1:
                movimientoAlryx.fuerzaSalto += 20;
                break;
            case 2:
               GameObject.FindGameObjectWithTag("Campo").SetActive(true);
                break;

            default:
                Debug.Log("Sin Efecto");
                break;
        }
    }
}