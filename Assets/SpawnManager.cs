using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class SpawnManager : MonoBehaviour

{

    public GameObject[] animalPrefabs;

    private float spawnRangeX = 10;

    private float spawnPosZ = 10;

    private float startDelay = 5;

    private float spawnInterval = 5.5f;

    //public int animslIndex;

    // Start is called before the first frame update

    void Start()

    {

        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

    }


    // Update is called once per frame

    void Update()

    {

        if (Input.GetKeyDown(KeyCode.S))

        {

            SpawnRandomAnimal();

        }

    }


    void SpawnRandomAnimal()

    {

        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }

}