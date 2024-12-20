using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Moving : MonoBehaviour
{
    private Rigidbody rb;
    private float time_ZombieMove;

    private void Start()
    {
        time_ZombieMove = Parameter_Zombie.Instance.time;      

        rb = GetComponent<Rigidbody>();       
    }


    private void FixedUpdate()
    {
        Moving_Wave1();
    }


    private void Moving_Wave1()
    {
        time_ZombieMove -= Time.deltaTime;
        if(time_ZombieMove <= 0)
        {
            rb.velocity = Vector3.forward * Parameter_Zombie.Instance.speedZombie;
        }       
    }

}
