using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BalaPlasma : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public GameObject efectoImpacto;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(Instantiate(efectoImpacto, transform.position, transform.rotation), 2.0f);
        Destroy(this.gameObject);
    }

}
