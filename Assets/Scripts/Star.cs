using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{


    [Header("Statistics")]
    [SerializeField] private float maxSpeed;
    [SerializeField] private float minSpeed;
    [SerializeField] private float lifetime;
    private float speed;

    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        Invoke("DestroySelf", lifetime);
    }


    private void Update()
    {
        transform.Translate(Vector2.right * -speed * Time.deltaTime);
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }

}
