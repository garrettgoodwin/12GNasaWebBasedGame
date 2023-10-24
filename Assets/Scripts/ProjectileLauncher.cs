using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    [Header("Statistics")]
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float launchCooldown;
    [SerializeField] private float lastLaunchedTime;

    [Header("References")]
    [SerializeField] private GameObject projectileObj;

    public void LaunchAt(Transform target)
    {
        Quaternion rotation = Quaternion.AngleAxis(Rotation(target) + 90, Vector3.forward);
        transform.rotation = rotation;

        if (Time.time >= lastLaunchedTime)
        {
            StartCoroutine(LaunchCoroutine());
            lastLaunchedTime = Time.time + launchCooldown;
        }
    }

    IEnumerator LaunchCoroutine()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(projectileObj, spawnPoint.position, transform.rotation);
    }

    public float Rotation(Transform target)
    {
        if (target != null)
        {
            //Subtracts the mouses position by the launch Cannons original position
            Vector2 direction = target.position - transform.position;

            //Atan2 -Output is in radians then multiplied to degrees
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            return angle;
        }
        return 0;
    }
}
