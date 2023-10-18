using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 0;

    public TextAlignment textoTimer;

    public TextMeshProUGUI textoTimerPro;

    void Update()
    {
        //timer -= Time.deltaTime;

        //textoTimer.text = "" + timer.ToString("f1");

        //textoTimerPro.text = "" + timer.ToString("f1");
    }
}
