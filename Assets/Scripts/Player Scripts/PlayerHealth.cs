using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int maxHealth;
    int currentHealth;

    private void Start()
    {
        //Initialize Health
        currentHealth = maxHealth;
    }

    public void DecreaseHealth(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void IncreaseHealth(int amount)
    {
        if (currentHealth < maxHealth)
        {
            currentHealth += amount;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
        }
    }

    public void Die()
    {
        Debug.Log("The player has perished");
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }
}
