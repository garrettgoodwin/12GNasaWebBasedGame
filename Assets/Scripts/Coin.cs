using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [Header("Statistics")]
    [SerializeField] private int valueAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            PlayerBank playerBank = collision.GetComponent<PlayerBank>();
                
            if(playerBank != null)
            {
                playerBank.IncreaseBankAmount(valueAmount);
                Destroy(gameObject);
            }
            else
            {
                Debug.LogWarning("Unable to increase player's bank as player bank is null");
            }
        }
    }
}
