using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructor : MonoBehaviour
{
    //Have the gameobject contian the particels
    [SerializeField] private GameObject destroyParticles;
    [SerializeField] private AudioSource[] destroySound;

    public void DestroyOneself()
    {
        if (destroyParticles != null)
        {
            //Spawn Particles

            //Problem here with timing -Destroy Object whcih contains particle system
            //destroyParticles.Play();

            Instantiate(destroyParticles, gameObject.transform);

        }

        if (destroySound.Length > 0)
        {
            //Play sound
            //destroySound.Play();

            int randomNumb = Random.Range(0, destroySound.Length);
            Instantiate(destroySound[randomNumb]);
        }

        Destroy(gameObject);
    }
}
