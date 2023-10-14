using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BalaFuego : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private AudioSource controlSonido;
    public AudioClip sonidoImpactoFuego;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        controlSonido = FindObjectOfType<AudioSource>();
        rb.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 1f);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Destroy(Instantiate(efectoImpacto, transform.position, transform.rotation), 2.0f);
    //    controlSonido.PlayOneShot(sonidoImpactoFuego);
    //    Destroy(this.gameObject);
    //}

}