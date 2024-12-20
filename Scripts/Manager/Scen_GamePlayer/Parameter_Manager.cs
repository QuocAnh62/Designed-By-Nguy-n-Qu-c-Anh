using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameter_Manager : MonoBehaviour
{
    public static Parameter_Manager Instance;
    [Header("=== Player ===")]
    public float speedPlayer;

    [Header("=== Animal ===")]
    public float speedAnimal;

    [Header("=== Feature Speed Up ===")]
    public float full_Stamina;
    public float current_Stamina;
    public float plusSpeed = 1f;

    [Header("=== Spawn ===")]
    public int number_Car;
   
    

    [Header("=== Times ===")]
    public float time_ShowButtonPlusSpeed = 7f;
    public float time_ToNormalSpeed = 15f;
    public float time_PlusStamina = 10f;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }


    private void Start()
    {
        speedPlayer = PlayerPrefs.GetFloat("Speed Player");
        number_Car = PlayerPrefs.GetInt("Number Car");
        speedAnimal = PlayerPrefs.GetFloat("Speed Animal");

        full_Stamina = PlayerPrefs.GetFloat("Stamina");
        current_Stamina = PlayerPrefs.GetFloat("Stamina");
    }

}
