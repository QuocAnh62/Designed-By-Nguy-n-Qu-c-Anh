using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnFlower : MonoBehaviour
{
    [SerializeField] private List<GameObject> flowerPerfab;
    [SerializeField] private Transform container;

    void Start()
    {
        NumOfFlowers();
    }

    private void NumOfFlowers()
    {
        for(int i = 0; i < 30; i++)
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        Vector3 PosFlower = SystemGetPosition.instance.GetRandomPosition();

        GameObject flower = Instantiate(flowerPerfab[Random.Range(0, flowerPerfab.Count)]);

        PositionForFlower(PosFlower, flower);   

        flower.transform.parent = container;    
    }
    
    private void PositionForFlower(Vector3 Pos ,GameObject flower)
    {
        if (flower.name == "Rose(Clone)")
        {
            flower.transform.position = Pos + new Vector3(0, 0.8f, 0);
        }
        else
        {
            flower.transform.position = Pos + new Vector3(0, 0.2f, 0);
        }
    }
}
