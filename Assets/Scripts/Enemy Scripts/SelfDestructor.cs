using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructor : MonoBehaviour
{
    //Have the gameobject contian the particels
    [SerializeField] private GameObject destroyParticles;
    [SerializeField] private AudioSource destroySound;

    public void DestroyOneself()
    {
        if (destroyParticles != null)
        {
            //Spawn Particles

            //Problem here with timing -Destroy Object whcih contains particle system
            //destroyParticles.Play();

            Debug.Log("FUCKING SPAWN IN");
            Instantiate(destroyParticles, gameObject.transform);

        }

        if (destroySound != null)
        {
            //Play sound
            //destroySound.Play();
        }

        Destroy(gameObject);
    }


    //Destroy this
    //IEnumerator TEMPFIX()
    //{
    //    yield return new WaitForSeconds(3f);
    //    Destroy(gameObject);
    //}


}
