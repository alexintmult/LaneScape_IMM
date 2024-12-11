using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstacle; // Obstacle prefab
    public float delay = 1f; // Delay between spawns

    public int start_z; // Starting z-position
    public int end_z; // Ending z-position

    public float road_min_x; // Minimum x-position (road width start)
    public float road_max_x; // Maximum x-position (road width end)

    private bool spawn = true;

    // Update is called once per frame
    void Update()
    {
        if (spawn)
        {
            StartCoroutine(spawn_obstacle());
        }
    }

    IEnumerator spawn_obstacle()
    {
        spawn = false;
        yield return new WaitForSeconds(delay);

        // Generate random positions
        int z = Random.Range(start_z, end_z); // Random z-position within range
        float x = Random.Range(road_min_x, road_max_x); // Random x-position across road width

        // Spawn obstacle at random position
        Vector3 spawnPosition = new Vector3(x, 5, z);
        GameObject obstacle_clone = Instantiate(obstacle, spawnPosition, Quaternion.identity);

        obstacle_clone.SetActive(true); // Activate the object if needed
        spawn = true; // Reset spawn flag to allow further spawning
    }
}
