using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalsList;

    public int SpawnRangeX = 20;

    public int SpawnPosZ = -1;

    public float StartDelay = 2f;

    public float SpawnInterval = 1.5f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", StartDelay, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);
        var animIndex = Random.Range(0, AnimalsList.Length);
        Instantiate(AnimalsList[animIndex], spawnPos, AnimalsList[animIndex].transform.rotation);
        
    }
}
