using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BalaLaser : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public GameObject efectoImpactoLaser;
    private AudioSource controlSonido;
    public AudioClip sonidoImpactoLaser;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        controlSonido = FindObjectOfType<AudioSource>();
        rb.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 4f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(Instantiate(efectoImpactoLaser, transform.position, transform.rotation), 2.0f);
        controlSonido.PlayOneShot(sonidoImpactoLaser);
        Destroy(this.gameObject);
    }

}