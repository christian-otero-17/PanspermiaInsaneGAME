using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPowers : MonoBehaviour
{
    public bool destruirConCursor;
    public bool destruirAutomatico;
    public MovimientoAlryxEscenario movimientoAlryx;
    public GameObject campoFuerza;

    public int tipo;
    //1 = Super Salto
    //2 = Campo Fuerza

    void Start()
    {
        movimientoAlryx = GameObject.FindGameObjectWithTag("Player").GetComponent<MovimientoAlryxEscenario>();
        campoFuerza = movimientoAlryx.CampoFuerza;
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
                movimientoAlryx.fuerzaSalto += 15;
                break;
            case 2:
               campoFuerza.SetActive(true);
                GameManager.Instace.tiempo += 10;
                break;

            default:
                Debug.Log("Sin Efecto");
                break;
        }
    }
}
