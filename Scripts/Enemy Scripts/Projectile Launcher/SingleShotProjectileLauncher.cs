using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShotProjectileLauncher : ProjectileLauncher
{
    public override void LaunchAt(Transform target)
    {
        Quaternion rotation = Quaternion.AngleAxis(Rotation(target) + 90, Vector3.forward);
        transform.rotation = rotation;

        if (Time.time >= lastLaunchedTime)
        {
            Instantiate(projectileObj, spawnPoint.position, transform.rotation);
            lastLaunchedTime = Time.time + launchCooldown;
        }
    }
}
