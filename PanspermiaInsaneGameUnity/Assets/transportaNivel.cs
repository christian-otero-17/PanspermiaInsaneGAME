using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transportaNivel : MonoBehaviour
{

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player") && GameManager.Instace.partesNave == 2)
        {
            SceneManager.LoadScene("Level3");
        }
    }
}