using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarArmas : MonoBehaviour
{
    public TomarArmas tomarArmas;
    public int numeroArma;
    public Animator animator;
    public bool estoyArmado;

    void Start()
    {
        tomarArmas = GameObject.FindGameObjectWithTag("Player").GetComponent<TomarArmas>();
        animator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {   
            animator.SetBool("Arma", true);
            tomarArmas.activarArmas(numeroArma);
            Destroy(gameObject);
            tomarArmas.desactivarImagenArma(numeroArma);
        }
    }
}
