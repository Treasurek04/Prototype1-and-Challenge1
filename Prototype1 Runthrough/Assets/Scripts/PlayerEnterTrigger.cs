/*
 Treasure Keys 
Prototype 1
When Player enters trigger zone then 1 point is added to the score 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnterTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("TriggerZone"))
        {
            //set the textbox text to "You Win!
            ScoreManager.score++;
        }
            
    }
   
}
