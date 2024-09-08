/*
 Treasure Keys 
Prototype 1
Add to score when player hits the trigger 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered) 
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
