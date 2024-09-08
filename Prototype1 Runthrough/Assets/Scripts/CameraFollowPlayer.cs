/*
 Treasure Keys 
Prototype 1
Camera Follows Player Setup
 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -10);

  
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
