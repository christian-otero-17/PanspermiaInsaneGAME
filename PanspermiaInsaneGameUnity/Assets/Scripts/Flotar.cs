using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flotar : MonoBehaviour
{
    public float profundidad = 0.5f;
    public float desplazamiento = 3f;
    public Rigidbody rig;

    private void FixedUpdate()
    {
        if(transform.position.y > 0f)
        {
            float multiplicadorDesplaza = Mathf.Clamp01(-transform.position.y / profundidad) * desplazamiento;
            rig.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y)*multiplicadorDesplaza, 0f),ForceMode.Acceleration);  
        }
    }
}