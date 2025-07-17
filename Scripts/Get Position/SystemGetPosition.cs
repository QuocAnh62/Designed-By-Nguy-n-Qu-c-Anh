using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemGetPosition : MonoBehaviour
{
    public static SystemGetPosition instance; // for 2 scripts SpawnFlower and SpawnCarrot
    
    [SerializeField] private Vector3 spawnSize;
    public HashSet<Vector3> usedPositions = new HashSet<Vector3>();
    public void Awake()
    {
        if (instance == null) { instance = this; }
    }

    public Vector3 GetRandomPosition()
    {
        Vector3 position;

        while (true)
        {
            float x = Random.Range(2, spawnSize.x - 1);
            float z = Random.Range(2, spawnSize.z - 1);

            // Kiểm tra nếu x và z nằm ngoài khoảng 22 -> 28
            if ((x < 24 || x > 36) || (z < 13 || z > 25))
            {
                position = new Vector3(x, 0, z);

                // Kiểm tra xem vị trí đã được sử dụng chưa
                if (!usedPositions.Contains(position))
                {
                    break; // Tìm được vị trí hợp lệ, thoát khỏi vòng lặp
                }
            }
        }
        return position;
    }
}
