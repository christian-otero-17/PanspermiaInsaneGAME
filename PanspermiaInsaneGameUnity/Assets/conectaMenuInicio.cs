using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class conectaMenuInicio : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);

    }
}
