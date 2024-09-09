/*
Treasure Keys 
Challenge 1
Make Propeller Spin every frame
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed = 100f;

    // Start is called before the first frame update
    private void Update()
    {
         transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}

