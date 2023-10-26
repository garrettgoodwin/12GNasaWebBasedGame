using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Statistics")]
    [SerializeField] private float speed;
    private Vector2 moveAmount;
    [SerializeField] private float sprintSpeedMultiplier;

    [Header("References")]
    private Rigidbody2D playerRigidBody;

    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();

        if (playerRigidBody == null)
        {
            Debug.LogError("Player Rigidbody Component is not assigned in PlayerMovement script");
        }
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveAmount = moveInput.normalized * speed; //normalized used in order to prevent diagonal movement increasing speed
    
        if(Input.GetKey(KeyCode.LeftShift))
        {
            moveAmount *= sprintSpeedMultiplier;
        }
    
    }

    private void FixedUpdate()
    {
        playerRigidBody.position += moveAmount * Time.fixedDeltaTime;
    }
}
