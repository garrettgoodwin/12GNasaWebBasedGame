using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    [Header("Statistics")]
    [SerializeField] private int damageAmount = 1;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float minSpeed;
    private float speed;

    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    private void Update()
    {
        transform.Translate(Vector2.right * -speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.DecreaseHealth(damageAmount);
                Destroy(gameObject);
            }
            else
            {
                Debug.LogWarning("Unable to increase player's health as player health is null");
            }
        }
    }
}
