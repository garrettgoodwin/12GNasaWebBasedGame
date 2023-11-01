using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Enemy
{

    void Update()
    {
        FollowPlayerWithinRange();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (player != null)
        {
            if (collision.gameObject == player.gameObject)
            {
                playerHealthScript.DecreaseHealth(damage);
                Die();
            }
        }

        if(collision.gameObject.tag == "Enemy")
        {
            Die();
        }


    }
}
