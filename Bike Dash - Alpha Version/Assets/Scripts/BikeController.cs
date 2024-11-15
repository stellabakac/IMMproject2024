using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 50.0f;

    void Update()
    {
        // Move forward and backward based on "Vertical" input (W/S or Up/Down arrows)
        float moveDirection = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * moveDirection * speed * Time.deltaTime);
        
        // Turn left and right based on "Horizontal" input (A/D or Left/Right arrows)
        float turnDirection = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnDirection * turnSpeed * Time.deltaTime);
    }
}
