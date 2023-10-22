using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private PlayerBank playerBank;
    private PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        InitializeComponents();
    }

    void InitializeComponents()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerBank = GetComponent<PlayerBank>();
        playerHealth = GetComponent<PlayerHealth>();

        if (playerMovement == null)
        {
            Debug.LogError("Player Movement Component is not assigned in Player script");
        }
        if (playerBank == null)
        {
            Debug.LogError("Player Bank Component is not assigned in Player script");
        }
        if(playerHealth == null)
        {
            Debug.LogError("Player Health Component is not assigned in Player script"); ;
        }
    }

}
