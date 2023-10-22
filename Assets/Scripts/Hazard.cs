using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    //Could have various different types of coins, so I made serializable
    [SerializeField] int valueAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.IncreaseHealth(valueAmount);
                Destroy(gameObject);
            }
            else
            {
                Debug.LogWarning("Unable to increase player's health as player health is null");
            }
        }
    }
}
