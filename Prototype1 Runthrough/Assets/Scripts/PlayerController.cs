﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    public float turnSpeed;

    public float forwardInput;

    public float horizontalInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move forward
        //transform.Translate(0,0,1);

        //Which is the same as...
        //transform.Translate(Vector3.forward);

        //Move forward 20 meters/second if speed is set to 20
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //Get Input - Do this in Update()
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
       
        //Move player side to side with horizontal Input
        //transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);

       //Move forward with forward input 
       transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotate player with horizontal Input
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    
    }
}
