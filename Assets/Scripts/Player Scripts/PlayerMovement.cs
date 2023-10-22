using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed;
    private Rigidbody2D playerRigidBody;
    private Vector2 moveAmount;


    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();

        if (playerRigidBody == null)
        {
            Debug.LogError("Player Rigidbody Component is not assigned in PlayerMovement script");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveAmount = moveInput.normalized * speed; //normalized used in order to prevent diagonal movement increasing speed
    }

    private void FixedUpdate()
    {
        playerRigidBody.position += moveAmount * Time.fixedDeltaTime;
    }
}
