using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal_Run : MonoBehaviour
{
    Rigidbody rb;
    bool isRun = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        CalculComeNear();
        if(isRun == true)
        {
            run();
        }
    }

    private void CalculComeNear()
    {
        Vector3 dirWithPlayer = Manager_Input.Instance.transforPlayer.position - transform.position;
        Vector3 dirWithLine = Manager_Input.Instance.finish_Line1.position - transform.position;

        if (dirWithPlayer.magnitude <= 60) isRun = true;
        if (dirWithLine.magnitude <= 35) isRun = false;
    }

    private void run()
    {
        rb.velocity = Vector3.forward * PlayerPrefs.GetFloat("Speed Animal");
    }
}
