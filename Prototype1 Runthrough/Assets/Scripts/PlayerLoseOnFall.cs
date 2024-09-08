using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Add this using statement when using Text UI elements
using UnityEngine.UI;

public class PlayerLoseOnFall : MonoBehaviour
{

    public Text textbox;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            textbox.text = "You Lose!";
        }
    }
}
