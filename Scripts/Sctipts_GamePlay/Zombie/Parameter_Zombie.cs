using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameter_Zombie : MonoBehaviour
{
    public static Parameter_Zombie Instance;

    public float speedZombie = 35f;
    public float time = 15f;


    private void Awake()
    {
        if(Instance == null) Instance = this;
    }
    private void Start()
    {
        speedZombie = PlayerPrefs.GetFloat("Speed Zombie");
    }
}
