using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalsPrefabs;

    private float startDelay = 2f;
    private float spawnInterval = 2.5f;
   
    private int rangeBorderX = 24;
    private int rangeBorderZ = 9;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        if(Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }    
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalsPrefabs.Length);
        int spawnSide = Random.Range(0, 4);

        if(spawnSide == 0)
        {
            //spawn from left
            int animalSpawnPointZ = Random.Range(-rangeBorderZ, rangeBorderZ);
            Vector3 spawnPosition = new Vector3(-rangeBorderX, 0, animalSpawnPointZ);
            Instantiate(animalsPrefabs[animalIndex], spawnPosition, Quaternion.LookRotation(Vector3.right, Vector3.up));
        }
        else if(spawnSide == 1)
        {
            //spawn from right
            int animalSpawnPointZ = Random.Range(-rangeBorderZ, rangeBorderZ);
            Vector3 spawnPosition = new Vector3(rangeBorderX, 0, animalSpawnPointZ);
            Instantiate(animalsPrefabs[animalIndex], spawnPosition, Quaternion.LookRotation(Vector3.left, Vector3.up));
        }
        else if(spawnSide == 2)
        {
            //spawn from top
            int animalSpawnPointX = Random.Range(-rangeBorderX, rangeBorderX);
            Vector3 spawnPosition = new Vector3(animalSpawnPointX, 0, rangeBorderZ);
            Instantiate(animalsPrefabs[animalIndex], spawnPosition, Quaternion.LookRotation(Vector3.back, Vector3.up));
        }
        else if(spawnSide == 3)
        {
            //spawn from bottom
            int animalSpawnPointX = Random.Range(-rangeBorderX, rangeBorderX);
            Vector3 spawnPosition = new Vector3(animalSpawnPointX, 0, -rangeBorderZ);
            Instantiate(animalsPrefabs[animalIndex], spawnPosition, Quaternion.LookRotation(Vector3.forward, Vector3.up));
        }
    }
}