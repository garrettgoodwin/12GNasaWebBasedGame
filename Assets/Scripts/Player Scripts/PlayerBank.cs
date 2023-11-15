using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlayerBank : MonoBehaviour
{
    private int totalAmount = 0;

    public UnityEvent OnCoinCountChanged;

    public void IncreaseBankAmount(int amount)
    {
        totalAmount += amount;
        OnCoinCountChanged?.Invoke();

        PrintOutAmount();
    }

    public void DecreaseAmount(int amount)
    {
        totalAmount -= amount;

        if(totalAmount < 0)
        {
            totalAmount = 0;
        }
        OnCoinCountChanged?.Invoke();
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
