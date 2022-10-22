using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{

    public GameObject[] ufoPrefabs; //Array to store UFO ships

    public int ufoIndex;

    private float spawnRangeX = 20f;

    private float spawnPosZ = 20f;

    private float startDelay = 2f;

    private float SpawnInterval = 1.5f;

void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, SpawnInterval);
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(ufoPrefabs[ufoIndex], new Vector3(0, 0, 15),
            ufoPrefabs[ufoIndex].transform.rotation);
    }
        }
        

    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int ufoIndex = Random.Range(0, ufoPrefabs.Length); // Picks a random UFO from the array
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation); //Spawns a indexed UFO from the array a random location on the x-axis

    }
}
