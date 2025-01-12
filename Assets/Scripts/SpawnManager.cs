using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] AnimalPrefabs; // 欲生成的動物種類
    [SerializeField] private Vector3 spawnPos = new Vector3(25, 0, 0);
    [SerializeField] private float startDelay = 2;
    
    private float spawnInterval; // 在指定範圍隨機生成
    [SerializeField] private float spawnIntervalMin = 1;
    [SerializeField] private float spawnIntervalMax = 2;

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal(){
        if(!PlayerController.isGameOver && GameStart.isGameStart){
            int animalIndex = Random.Range(0, AnimalPrefabs.Length);
            Instantiate(AnimalPrefabs[animalIndex], spawnPos, AnimalPrefabs[animalIndex].transform.rotation);
        }
    }
}
