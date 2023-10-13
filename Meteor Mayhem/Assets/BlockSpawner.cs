using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    // Reference to the block prefab
    public GameObject blockPrefab;

    // Reference to the spaceship
    public Transform spaceship;

    // Number of blocks to spawn
    public int numberOfBlocks = 10;

    // Spawn interval
    public float spawnInterval = 1.0f;

    // Spawn radius
    public float spawnRadius = 10.0f;

    private void Start()
    {
        // Invoke the SpawnBlock method repeatedly
        InvokeRepeating("SpawnBlock", 0, spawnInterval);
    }

    void SpawnBlock()
    {
        // Spawn a block at a random position within the spawn radius
        Vector3 randomPosition = spaceship.position + Random.insideUnitSphere * spawnRadius;
        Instantiate(blockPrefab, randomPosition, Quaternion.identity).GetComponent<BlockMovement>().spaceship = spaceship;
        numberOfBlocks--;

        // If there are no more blocks to spawn, cancel the invoke
        if (numberOfBlocks <= 0)
        {
            CancelInvoke("SpawnBlock");
        }
    }
}
