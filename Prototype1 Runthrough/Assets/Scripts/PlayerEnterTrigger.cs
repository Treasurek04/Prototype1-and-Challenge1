using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Add this using statement when using Text UI elements 
using UnityEngine.UI;

public class PlayerEnterTrigger : MonoBehaviour
{
    public Text textbox;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Finish"))
        {
            //set the textbox text to "You Win!
            textbox.text = "You Win!";
        }
            
    }
   
}
