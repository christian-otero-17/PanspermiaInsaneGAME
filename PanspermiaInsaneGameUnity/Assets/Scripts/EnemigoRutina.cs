using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoRutina : MonoBehaviour
{
    public int rutina;
    public float cronometro;
    public Animator anim;
    public Quaternion angulo;
    public float grado;
    private Rigidbody rbEnemigo;
    public GameObject target;
    public bool atacando;
    int contadorColisiones = 0;

    void Start()
    {
        anim = GetComponent<Animator>();
        target = GameObject.Find("Alryx1009");
        rbEnemigo = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Comportamiento_Enemigo();
    }

    public void Comportamiento_Enemigo()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > 20)
        {
            anim.SetBool("Run", false);
            cronometro += 1 * Time.deltaTime;
            if (cronometro >= 4)
            {
                rutina = Random.Range(0, 2);
                cronometro = 0;
            }
            switch (rutina)
            {
                case 0:
                    anim.SetBool("Walk", false);
                    break;

                case 1:
                    grado = Random.Range(0, 360);
                    angulo = Quaternion.Euler(0, grado, 0);
                    rutina++;
                    break;

                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
                    transform.Translate(Vector3.forward * 2 * Time.deltaTime);
                    anim.SetBool("Walk", true);
                    break;

            }
        }
        else
        {
            if (Vector3.Distance(transform.position, target.transform.position) > 1 && !atacando)
            {
                var lookPos = target.transform.position - transform.position;
                lookPos.y = 0;
                var rotation = Quaternion.LookRotation(lookPos);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 3);
                anim.SetBool("Walk", false);

                anim.SetBool("Run", true);
                transform.Translate(Vector3.forward * 6 * Time.deltaTime);
                anim.SetBool("Attack", false);

            }
            else
            {
                anim.SetBool("Walk", false);
                anim.SetBool("Run", false);

                anim.SetBool("Attack", true);
                atacando = true;
            }
        }
    }
    public void Final_Ani()
    {
        anim.SetBool("Attack", false);
        atacando = false;
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Bala") || coll.CompareTag("AlienGolpe"))
        {
            contadorColisiones++;
            print("*******ENEMIGO DAÑO *******");

            if(contadorColisiones > 5)
            {
                print("*******ENEMIGO MUERTO *******");

                Destroy(gameObject);
            }
            
        }
    }
}
