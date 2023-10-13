using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementController : MonoBehaviour
{
    public float moveSpeed = 5.0f; //smoothness of movement
    public float rotationSpeed = 100.0f; //smoothness of rotation

    public int collisionCount = 0; //starting score is zero
    public GameObject[] objectsToCount; //the collisions with these objects will increase the score

    private void Update()
    {
        // Capture user input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        //Debug.Log("horizontal: " + horizontalInput + "\nvertical: " + verticalInput);
     
        // Calculate movement and rotation
        Vector3 movement = new Vector3(verticalInput, 0.5f, horizontalInput) * moveSpeed * Time.deltaTime; //verticalInput, 0.5f
        transform.Translate(movement);

        //float rotation = Input.GetAxis("Rotate") * rotationSpeed * Time.deltaTime;
        //transform.Rotate(Vector3.up * rotation);

        /* TO-DOS:
         * first person and third person switch 
         */
    }

    //when object comes in contact with another collider
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision detected");

        foreach (GameObject obj in objectsToCount)
        {
            if (collision.gameObject == obj)
            {
                collisionCount++;
                //Debug.Log("Collisions: " + collisionCount.ToString());
                break; // Exit the loop after a collision is detected
            }
        }
    }
}
