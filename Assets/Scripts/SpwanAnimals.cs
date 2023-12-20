using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanAnimals : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnDelay = 5f;
    private float spawnInterval = 5f;
  private void OnEnable()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnInterval);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    void Update()
    {
       
    }
    private void Spawn()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spwanPos = new Vector3(Random.Range(-20, 20), 0, 20);
        Instantiate(animalPrefabs[animalIndex], spwanPos, animalPrefabs[animalIndex].transform.rotation);

    }
    
}
