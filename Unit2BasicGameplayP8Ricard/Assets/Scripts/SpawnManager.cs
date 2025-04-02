using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnRangeZ = 15;
    private float spawnPosX = 20;
    private float spawnPosZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalUp", 2, 1.5f);
        InvokeRepeating("SpawnRandomAnimalLeft", 2, 1.5f);
        InvokeRepeating("SpawnRandomAnimalRight", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimalUp()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(0, spawnRangeZ));
        Quaternion rotationLeft = Quaternion.Euler(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, rotationLeft);
    }

    void SpawnRandomAnimalRight() 
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(0, -spawnRangeZ));
        Quaternion rotationLeft = Quaternion.Euler(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, rotationLeft);
    }
}
