using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationUpDown : MonoBehaviour
{   
    private float amplitude = 0.25f; // points dead high
    private float speed = 4.5f; // spped up down
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }


    private void FixedUpdate()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * speed) * amplitude;

        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
