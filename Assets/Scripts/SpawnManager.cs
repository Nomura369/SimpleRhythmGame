using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // [SerializeField] private GameObject[] AnimalPrefabs; // 欲生成的動物種類
    // [SerializeField] private Vector3 spawnPos = new Vector3(25, 0, 0);
    // [SerializeField] private float startDelay = 1.5f;
    
    // private float spawnInterval;
    // private float randomChange;
    // [SerializeField] private float randomChangeMax = 3;
    // [SerializeField] private float randomChangeMin = 1;

    // Start is called before the first frame update
    void Start()
    {
        // randomChange = Random.Range(randomChangeMin, randomChangeMax);
        // spawnInterval = (60 / bpm) * randomChange;
        // InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRandomAnimal(){
        // int animalIndex = Random.Range(0, AnimalPrefabs.Length);
        // Instantiate(AnimalPrefabs[animalIndex], spawnPos, AnimalPrefabs[animalIndex].transform.rotation);
    }
}
