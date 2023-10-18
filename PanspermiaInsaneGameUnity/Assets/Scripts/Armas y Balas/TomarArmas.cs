using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Unity.VisualScripting;
using UnityEngine;

public class TomarArmas : MonoBehaviour
{
    ActivarArmas activararmas;
    public GameObject[] armas;
    public Animator animator;
    public GameObject[] imagenesArmas;
    public GameObject[] tipoBala;
    public GameObject balaActiva;
    public AudioClip[] tipoSonidoDisparo;
    public AudioClip sonidoActivo;


    int numArma;


    private void Start()
    {
        animator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            desactivarArmas();

        }
    }

    public void activarArmas(int numero)
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
            imagenesArmas[i].SetActive(false);
            tipoBala[i].SetActive(false);
        }
        armas[numero].SetActive(true);
        imagenesArmas[numero].SetActive(true);
        tipoBala[numero].SetActive(true);
        balaActiva = tipoBala[numero];
        sonidoActivo = tipoSonidoDisparo[numero];
        GameManager.Instace.armaMunicion += 200;



    }

    public void desactivarArmas()
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
            imagenesArmas[i].SetActive(false);
            tipoBala[i].SetActive(false);

            animator.SetBool("Arma", false);
            GameManager.Instace.armaMunicion = 0;

        }
    }

    public void desactivarImagenArma(int numero)
    {
        for (int i = 0; i < armas.Length; i++)
        {
            imagenesArmas[i].SetActive(false);

        }
        imagenesArmas[numero].SetActive(true);
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Arma"))
    //        GameManager.Instace.armaMunicion += other.gameObject.GetComponent<BalasArma>().balas;
    //}

}