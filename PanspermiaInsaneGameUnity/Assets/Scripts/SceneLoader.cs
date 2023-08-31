using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("VideoIntroJuego", LoadSceneMode.Single);

        //if (Input.GetKeyDown(KeyCode.Space)){

        //    if (EditorSceneManager.GetActiveScene().buildIndex == 0)
        //    {
        //        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        //    }
        //}
    }
}