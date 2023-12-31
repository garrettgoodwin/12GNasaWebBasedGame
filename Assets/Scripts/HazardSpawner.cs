using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardSpawner : MonoBehaviour
{
    [Header("Statistics")]
    [SerializeField] private float spawnCooldown;
    [SerializeField] private float initialSpawnTime;
    [SerializeField] private float timeDecreaseRate;
    [SerializeField] private float timeUntilNextSpawn;

    [Header("References")]
    [SerializeField] private Transform[] spawnpointTransforms;
    [SerializeField] private GameObject[] hazardPrefabs;

    void Update()
    {
        if (timeUntilNextSpawn <= 0)
        {
            SpawnHazardAtRandomSpawnPoint();

            if (initialSpawnTime > spawnCooldown)
            {
                initialSpawnTime -= timeDecreaseRate;
            }

            timeUntilNextSpawn = initialSpawnTime;
        }
        else
        {
            timeUntilNextSpawn -= Time.deltaTime;
        }
    }

    /// <summary>
    /// This function selects a random spawnpoint from the array of available spawnpoints
    /// and instantiates a hazards prefab at that spawnpoint.
    /// </summary>
    void SpawnHazardAtRandomSpawnPoint()
    {
        Transform randomSpawnpoint = spawnpointTransforms[Random.Range(0, spawnpointTransforms.Length)];
        GameObject randomHazard = hazardPrefabs[Random.Range(0, hazardPrefabs.Length)];
        Instantiate(randomHazard, randomSpawnpoint.position, Quaternion.identity);
    }
}
