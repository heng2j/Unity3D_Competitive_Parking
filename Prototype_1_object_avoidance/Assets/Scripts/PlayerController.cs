using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float throttleInput;

    public string inputId;


    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal" + inputId);
        throttleInput = Input.GetAxis("Vertical" + inputId);

        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * throttleInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        

    }
}








                         