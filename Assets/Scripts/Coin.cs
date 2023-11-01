using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [Header("Statistics")]
    [SerializeField] private int valueAmount = 1;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float minSpeed;
    [SerializeField] private float lifetime;
    [SerializeField] private float speed;

    [Header("References")]
    [SerializeField] private SelfDestructor selfDestructor;



    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        Invoke("DestroySelf", lifetime);
    }

    private void Update()
    {
        transform.Translate(Vector2.right * -speed * Time.deltaTime);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            PlayerBank playerBank = collision.GetComponent<PlayerBank>();
                
            if(playerBank != null)
            {
                playerBank.IncreaseBankAmount(valueAmount);
                selfDestructor.DestroyOneself();
            }
            else
            {
                Debug.LogWarning("Unable to increase player's bank as player bank is null");
            }
        }
    }
}
