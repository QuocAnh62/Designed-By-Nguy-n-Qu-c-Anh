using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCarrot : MonoBehaviour
{
    public static SpawnCarrot instance; // for Scripts PickUpCarrot

    public GameObject carrotPerfab;
    public Transform container;
    public List<GameObject> poolCarrot = new List<GameObject>();

    private float timeSpawn = 0f;

    private void Awake()
    {
        if (instance == null) { instance = this; }
    }
    private void Start()
    {
        StartCoroutine(Spawn());
    }


    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(timeSpawn);
        for (int i = 0; i < 20; i++)
        {
            Vector3 position = SystemGetPosition.instance.GetRandomPosition();
            GameObject carrot = Instantiate(carrotPerfab, position, Quaternion.identity);
            carrot.transform.parent = container;
            poolCarrot.Add(carrot);
        }    
      
    }

    public void RespawnCarrot()
    {
        SystemGetPosition.instance.usedPositions.Clear();

        foreach (GameObject carrot in poolCarrot)
        {
            if (!carrot.activeSelf)
            {
                Vector3 position = SystemGetPosition.instance.GetRandomPosition();
                carrot.transform.position = position;
                carrot.SetActive(true);
                SystemGetPosition.instance.usedPositions.Add(position);
            }
        }
    }

}
