using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 100.0f;

    private void Update()
    {
        // Capture user input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Debug.Log("horizontal: " + horizontalInput + "\nvertical: " + verticalInput);
     
        // Calculate movement and rotation
        Vector3 movement = new Vector3(verticalInput, 0.5f, horizontalInput) * moveSpeed * Time.deltaTime; //verticalInput, 0.5f
        transform.Translate(movement);
        
        //float rotation = Input.GetAxis("Rotate") * rotationSpeed * Time.deltaTime;
        //transform.Rotate(Vector3.up * rotation);
    }
}
