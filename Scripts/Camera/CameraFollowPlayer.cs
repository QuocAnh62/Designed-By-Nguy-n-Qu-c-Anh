using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform transformPlayer;
    void Update()
    {
        transform.position = transformPlayer.position + new Vector3(0, 13, -20);
    }
}
