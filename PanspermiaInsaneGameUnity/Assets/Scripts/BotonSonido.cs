using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BotonSonido : MonoBehaviour
{
    public AudioSource mySounds;
    public AudioClip hoverSound;
    public AudioClip click;

    public void HoverSound()
    {
        mySounds.PlayOneShot(hoverSound);
    }
    public void ClickSound()
    {
        mySounds.PlayOneShot(click);
    }
}
