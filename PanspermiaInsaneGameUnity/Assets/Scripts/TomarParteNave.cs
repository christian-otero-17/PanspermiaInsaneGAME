using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomarParteNave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instace.tomarParte(1);
            Destroy(gameObject);
        }
    }
}
