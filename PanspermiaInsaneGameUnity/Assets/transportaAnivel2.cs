using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transportaAnivel2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider coll)
    {
            if (coll.CompareTag("Player") && GameManager.Instace.partesNave == 1)
            {
                SceneManager.LoadScene("Level2");
        }
    }
}