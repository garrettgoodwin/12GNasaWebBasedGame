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
    [SerializeField] protected AudioSource[] playerHurtSounds;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private float inVulnerabilityDuration;

    private bool inVulnerable;


    public UnityEvent OnPlayerDeath;

    private void Start()
    {
        //Initialize Health
        currentHealth = maxHealth;
    }

    public void DecreaseHealth(int amount)
    {

        if(!inVulnerable)
        {
            currentHealth -= amount;

            int randNumb = Random.Range(0, playerHurtSounds.Length);
            Instantiate(playerHurtSounds[randNumb]);

            StartCoroutine(InvulnerabilityEffect(inVulnerabilityDuration));


            if (currentHealth <= 0)
            {
                Die();
            }
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

    IEnumerator InvulnerabilityEffect(float invulnerabilityTime)
    {
        inVulnerable = true;

        float timer = 0;
        float colorFlickerTime = .1f;

        while(timer < inVulnerabilityDuration)
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
            yield return new WaitForSeconds(colorFlickerTime);

            //spriteRenderer.color = Color.red;
            //yield return new WaitForSeconds(colorFlickerTime);
            //spriteRenderer.color = Color.white;
            //yield return new WaitForSeconds(colorFlickerTime);
            timer += (colorFlickerTime);
        }

        spriteRenderer.enabled = true;
        inVulnerable = false;
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
