using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ObstaclePrefabs;
    private Vector3 spawnPosition;
    private float xRange = 200f;
    private float yRange = 200f;
    private float zRange = 200f;
    private float startTime = 3f;
    private float repeatRate = 5f;
    private float randomX;
    private float randomY;
    private float randomZ;
    private int randomIndex;


    void Start()
    {
        InvokeRepeating("SpawnObstacle", startTime, repeatRate);
    }

    public Vector3 RandomSpawnPosition()
    {
      
        randomX = Random.Range(-xRange, xRange);
        randomY = Random.Range(-yRange, yRange);
        randomZ = Random.Range(-zRange, zRange);
        return new Vector3(randomX, randomY, randomZ);


    }


    public void SpawnObstacle()
    {
        randomIndex = Random.Range(0, ObstaclePrefabs.Length);
        spawnPosition = RandomSpawnPosition();
        Instantiate(ObstaclePrefabs[randomIndex], spawnPosition,
            ObstaclePrefabs[randomIndex].transform.rotation);
    }



}
