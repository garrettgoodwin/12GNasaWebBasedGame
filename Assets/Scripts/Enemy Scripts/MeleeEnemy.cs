using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

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
                CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, .1f);
                Die();
            }
        }

        if(collision.gameObject.tag == "Enemy")
        {
            CameraShaker.Instance.ShakeOnce(4f, 4f, .2f, .2f);
            Die();
        }


    }
}
