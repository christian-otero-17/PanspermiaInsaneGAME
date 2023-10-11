using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class TomarArmas : MonoBehaviour
{
    public GameObject[] armas;
    public Animator animator;
    public GameObject[] balasArmas;

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
        }
        armas[numero].SetActive(true);
    }

    public void desactivarArmas()
    {
        for (int i = 0; i < armas.Length; i++)
        {
            armas[i].SetActive(false);
            animator.SetBool("Arma", false);

        }
    }


}