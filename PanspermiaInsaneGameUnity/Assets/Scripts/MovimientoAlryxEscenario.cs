using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using Random = UnityEngine.Random;

public class MovimientoAlryxEscenario : MonoBehaviour
{
    //CAIDA AL VACIO REINICIAR

    float xInicial, yInicial, zInicial;

    //DISPARO CON ARMAS
    public bool shooting;
    public GameObject firepoint;

    //SONIDO DISPARO
    private AudioSource controlSonido;
    public AudioClip sonidoDisparo;

    //AnimacionesArmas
    public ActivarArmas activararmas;
    public TomarArmas tomarArmas;
    public int numeroArma;


    //GOLPEAR
    public bool golpeando;
    public int numGolpe;

    //Personaje Movimiento
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    public Animator anim;
    public float x, y;

    //CORRER
    public int velCorrer;

    //Caida mas rapida
    public int fuerzaExtra;

    //Personaje Saltando
    public Rigidbody rb;
    public int fuerzaSalto;
    public bool puedoSaltar;
    public float velocidadInicial;
    public float velocidadAgachado;

    //Sonido Golpes
    public AudioClip sonidoGolpe;
    public AudioClip sonidoSalto;


    //CAMBIO DE COLLIDER AGACHADO
    public CapsuleCollider colParado;
    public CapsuleCollider colAgachado;
    public GameObject cabeza;
    public LogicaCabeza logicaCabeza;
    public bool estoyAgachado;

    // Start is called before the first frame update
    void Start()
    {

        controlSonido = FindObjectOfType<AudioSource>();

        //REINICIO DE VALORES POR CADA MUERTE

        fuerzaSalto = 25;
        fuerzaExtra = 3;

        //REINICIO DE POSICIÓN CON CAIDA AL VACIO
        
        xInicial = transform.position.x;
        yInicial = transform.position.y;
        zInicial = transform.position.z;

        //////////////////////////////

        puedoSaltar = false;

        anim = GetComponent<Animator>();

        velocidadInicial = velocidadMovimiento;
        velocidadAgachado = velocidadMovimiento * 0.5f;

        activararmas = GameObject.FindGameObjectWithTag("Arma").GetComponent<ActivarArmas>();


    }
    void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift)&& !estoyAgachado && puedoSaltar)
        {
            velocidadMovimiento = velCorrer;
            if (y > 0)
            {
                anim.SetBool("Correr", true);

            }
            else
            {
                anim.SetBool("Correr", false);
            }
        }
        else
        {
            anim.SetBool("Correr", false);
            if (estoyAgachado)
            {
                velocidadMovimiento = velocidadAgachado;
            }else if (puedoSaltar)
            {
                velocidadMovimiento = velocidadInicial;
            }

        }

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (puedoSaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("Salte", true);
                rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
                controlSonido.PlayOneShot(sonidoSalto);

            }

            if (Input.GetKey(KeyCode.LeftAlt))
            {
                anim.SetBool("Agachado", true);
               // velocidadMovimiento = velocidadAgachado;

                /////CAMBIO DE COLLIDER//////////

                colAgachado.enabled = true;
                colParado.enabled = false;

                cabeza.SetActive(true);
                estoyAgachado = true;

                ////////////////////////////
            }
            else
            {
                if(logicaCabeza.contadorDeColision <= 0)
                {
                    anim.SetBool("Agachado", false);
                  //  velocidadMovimiento = velocidadInicial;

                    ////// CAMBIO COLLIDER //////
                    cabeza.SetActive(false);
                    colAgachado.enabled = false;
                    colParado.enabled = true;
                    estoyAgachado = false;

                }
                
            }
            anim.SetBool("TocoSuelo", true);

        }
        else
        {
            EstoyCayendo();
        }


        if (anim.GetBool("Arma") == true)
        {

            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (GameManager.Instace.armaMunicion > 0)
                {
                    GameManager.Instace.armaMunicion--;
                    anim.SetBool("Disparando", true);
                    Instantiate(tomarArmas.balaActiva, firepoint.transform.position, firepoint.transform.rotation);
                    controlSonido.PlayOneShot(tomarArmas.sonidoActivo);
                }
                else 
                {
                    tomarArmas.desactivarArmas();
                    anim.SetBool("Disparando", false);

                }
            }
            else
            {
                anim.SetBool("Disparando", false);

            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {

                int randomNum = Random.Range(0, 3);
                anim.SetInteger("NumGolpe", randomNum);
                anim.SetBool("Golpeando", true);
                controlSonido.PlayOneShot(sonidoGolpe);

            }
            else
            {
                anim.SetBool("Golpeando", false);

            }
        }



    }


    //TERMINA UPDATE
    public void EstoyCayendo()
    {
        //CAER MAS RAPIDO
        rb.AddForce(fuerzaExtra * Physics.gravity);

        anim.SetBool("TocoSuelo", false);
        anim.SetBool("Salte", false);
    }

    public void RecolocarPersonaje()
    {
        transform.position = new Vector3(xInicial, yInicial, zInicial);
    }


    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Puño"))
        {
            print("*******DAÑOOOOO*******");
        }
    }
}
