using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivarPausa : MonoBehaviour
{
    public bool pause;
    public GameObject pauseMenu;
    public GameObject HUD;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            Pausa();
        }

    }
    public void Pausa()
    {
            pause = !pause;
            pauseMenu.SetActive(pause);
            HUD.SetActive(false);
        if (pause)
        {
            Time.timeScale = 0f;
        } else
        {
            HUD.SetActive(true);

            Time.timeScale = 1f;
        }

    }
    public void quitaPausa()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        HUD.SetActive(true);

    }
}


