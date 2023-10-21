using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trasnportaAGameOver : MonoBehaviour
{
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player") && GameManager.Instace.partesNave == 3)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
