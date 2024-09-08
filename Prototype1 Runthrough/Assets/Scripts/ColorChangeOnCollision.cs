using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeOnCollision : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Turn this object Red
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
   
}
