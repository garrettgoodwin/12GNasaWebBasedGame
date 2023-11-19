using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBank : MonoBehaviour
{
    private int totalAmount = 0;

    public void IncreaseBankAmount(int amount)
    {
        totalAmount += amount;
        PrintOutAmount();
    }

    public void DecreaseAmount(int amount)
    {
        totalAmount -= amount;

        if(totalAmount < 0)
        {
            totalAmount = 0;
        }
        PrintOutAmount();
    }

    public int GetBankAmount()
    {
        return totalAmount;
    }

    void PrintOutAmount()
    {
        Debug.Log("Players Bank Amount is currently at: " + totalAmount);
    }
}
