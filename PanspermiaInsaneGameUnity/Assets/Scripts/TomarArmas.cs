using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class TomarArmas : MonoBehaviour
{
    public GameObject[] armas;
    public Animator animator;
    public GameObject[] imagenesArmas;

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

        }
        armas[numero].SetActive(true);
        imagenesArmas[numero].SetActive(true);
    }

    public void desactivarArmas()
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
            imagenesArmas[i].SetActive(false);
            animator.SetBool("Arma", false);

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

}