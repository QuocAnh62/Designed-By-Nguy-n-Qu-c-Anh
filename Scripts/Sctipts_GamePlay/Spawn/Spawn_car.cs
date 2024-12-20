using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_car : MonoBehaviour
{
    [SerializeField] private List<GameObject> car_Perfab;

    public float minX, maxX; 
    public float minZ, maxZ; 

    void Start()
    {
        CalculPosSpawn();
    }

    private void CalculPosSpawn()// calculate Position spawn
    {
        for (int i = 0; i < PlayerPrefs.GetInt("Number Car"); i++)
        {
            // calculate random position spawn
            Vector3 randomPosition =
                new Vector3(UnityEngine.Random.Range(minX, maxX), 2f, UnityEngine.Random.Range(minZ, maxZ));

            // calculate random rotation axis Y
            Quaternion rotation = Quaternion.Euler(0, UnityEngine.Random.Range(45, 90), 0);
           
            SpawnObjec(randomPosition, rotation);
        }
    }


    private void SpawnObjec(Vector3 randomPos, Quaternion randomRotation) // spawn car
    {
        GameObject spawnCar =
               Instantiate(car_Perfab[UnityEngine.Random.Range(0, car_Perfab.Count)], randomPos, randomRotation);          
        
        spawnCar.transform.parent = transform;
    }

}
