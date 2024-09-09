/*
 Treasure Keys 
Challenge 1
When Player enters the trigger zone then the score gets incremanted once 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddsScore : MonoBehaviour
{
    // Start is called before the first frame update
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
