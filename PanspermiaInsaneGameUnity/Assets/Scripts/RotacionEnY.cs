using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionEnY : MonoBehaviour
{
    public int RotacionItems = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, RotacionItems, 0f) * Time.deltaTime);
    }
}
