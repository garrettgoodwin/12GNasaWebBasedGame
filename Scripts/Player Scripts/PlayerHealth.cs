using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [Header("Statistics")]
    [SerializeField] private int maxHealth;
    private int currentHealth;
    private SelfDestructor selfDestructor;


    public UnityEvent OnPlayerDeath;

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
        //Doesnt technically need to happen if the scene is just reset
        //selfDestructor.DestroyOneself();
        OnPlayerDeath?.Invoke();
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }
}
