using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Projectile statistics
    [SerializeField] private float speed;
    [SerializeField] private float lifeTime;
    [SerializeField] private int damage;
    [SerializeField] private bool hitObject;

    void Start()
    {
        Invoke(nameof(DestroyProjectile), lifeTime);
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime); // Framerate independent time.deltaTime
    }

    void DestroyProjectile()
    {
        if (gameObject != null)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Just Entered Here");


        if (collision.tag == "Player")
        {
            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.DecreaseHealth(damage);
                Destroy(gameObject);
            }
            else
            {
                Debug.LogWarning("Unable to increase player's health as player health is null");
            }
        }
    }



}
