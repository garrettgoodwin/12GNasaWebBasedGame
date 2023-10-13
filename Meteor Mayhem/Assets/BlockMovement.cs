using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    // Reference to the spaceship 
    public Transform spaceship;

    // Speed of the block
    public float speed = 5.0f;

    void Update()
    {
        // Calculate the direction towards the spaceship
        Vector3 direction = (spaceship.position - transform.position).normalized;

        // Move the block in the calculated direction
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
