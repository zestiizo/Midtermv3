using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] goodplantPrefabs;
    public GameObject[] badplantPrefabs;
    private float goodstartDelay = 2;
    private float goodspawnInterval = 1.5f;
    private float badstartDelay = 5;
    private float badspawnInterval = 1.5f;
    private int xPos;
    private int zPos;


    void Start()
    {
        InvokeRepeating("SpawnRandomGoodPlant", goodstartDelay, goodspawnInterval);
        InvokeRepeating("SpawnRandomBadPlant", badstartDelay, badspawnInterval);
        
    }

    
    void Update()
    {
        
    }


    void SpawnRandomGoodPlant()
    {
        xPos = Random.Range(-20, 35);
        zPos = Random.Range(-32, 22);
        int goodplantIndex = Random.Range(0, goodplantPrefabs.Length);
        Vector3 spawnPos = new Vector3(xPos, 0, zPos);
        
        Instantiate(goodplantPrefabs[goodplantIndex], spawnPos, goodplantPrefabs[goodplantIndex].transform.rotation);
        
    }

    void SpawnRandomBadPlant()
    {
        xPos = Random.Range(-20, 35);
        zPos = Random.Range(-32, 22);
        int badplantIndex = Random.Range(0, badplantPrefabs.Length);
        Vector3 spawnPos = new Vector3(xPos, 0, zPos);

        Instantiate(badplantPrefabs[badplantIndex], spawnPos, badplantPrefabs[badplantIndex].transform.rotation);
    }
}
