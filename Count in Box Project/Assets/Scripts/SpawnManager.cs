using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float spawnDelay = 2;
    float repeatRate = 2;
    public GameObject spawnPrefab;
    float spawnRange = 90;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSpheres", spawnDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnSpheres()
    {
        Instantiate(spawnPrefab, GenerateLocationOption(spawnRange), Quaternion.Euler(0f, Random.Range(0f, 360f), 0f));
    }
    public static Vector3 GenerateLocationOption(float spawnRange)
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPosition = new Vector3(spawnPosX, 2, spawnPosZ);
        return randomPosition;
    }
}
