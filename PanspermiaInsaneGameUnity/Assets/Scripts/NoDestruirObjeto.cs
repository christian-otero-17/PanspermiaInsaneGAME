using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NoDestruirObjeto : MonoBehaviour
{
    private void Awake()
    {
        //var noDestruirEntreEscenas = FindObjectsOfType<NoDestruirObjeto>();
        //if (noDestruirEntreEscenas.Length > 1)
        //{
        //    Destroy(gameObject);
        //    return;
        //}
        DontDestroyOnLoad(gameObject);
    
    }
    void Start()
    {
        
    }


}
