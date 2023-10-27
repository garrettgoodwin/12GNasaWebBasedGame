using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructor : MonoBehaviour
{
    [SerializeField] private ParticleSystem destroyParticles;
    [SerializeField] private ParticleSystem destroySound;


    public void DestroyOneself()
    {
        if (destroyParticles != null)
        {
            //Spawn Particles
        }

        if (destroySound != null)
        {
            //Play sound
            //destroySound.Play();
        }

        Destroy(gameObject);
    }



}
