using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CoinManager : MonoBehaviour
{
    public int playerCoins = 0; // The player's coin count
    public TextMeshProUGUI coinText; // Reference to the Text component

    // Function to update the displayed coin count
    public void UpdateCoinDisplay()
    {
        coinText.text = "Coins: " + playerCoins;
    }

    // Function to add coins to the player's count
    public void AddCoins(int amount)
    {
        playerCoins += amount;
    }

    // Function to spend coins
    public bool SpendCoins(int amount)
    {
        if (playerCoins >= amount)
        {
            playerCoins -= amount;
            return true; // Coins spent successfully
        }
        else
        {
            return false; // Insufficient coins
        }
    }
}
