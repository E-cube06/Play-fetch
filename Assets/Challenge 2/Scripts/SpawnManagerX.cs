using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    public float spawnLimitXLeft = -22.0f;
    public float spawnLimitXRight = 7.0f;
    public float spawnPosY = 30.0f;
    public float startDelay = 1.0f;
    public float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
         float spawnInterval = Random.Range(3.0f, 5.0f);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
