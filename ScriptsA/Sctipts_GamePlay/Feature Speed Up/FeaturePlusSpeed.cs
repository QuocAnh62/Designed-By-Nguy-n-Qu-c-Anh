using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FeaturePlusSpeed : MonoBehaviour
{
    [SerializeField] private StaminaBar stamina_Bar;
    [SerializeField] private Clock_Speed clock_Speed;
    private float time; // This is time set back to normal speed

    private float plus_Speed;
    private float stamina_NeedPlsSpeed;

    private float equal = 0;
    bool isPlus = true;

    private void Start()
    {
        plus_Speed = Parameter_Manager.Instance.plusSpeed;
        stamina_NeedPlsSpeed = Parameter_Manager.Instance.speedPlayer;
        time = Parameter_Manager.Instance.time_ToNormalSpeed; // set time set to back normal speed 

        StartCoroutine(BackToNormalSpeed());       
    }

    private void Update()
    {
        if (Parameter_Manager.Instance.current_Stamina <= 11)
        {
            isPlus = false;
        }
    }

    public void PlusSpeed()
    {
        Manager_AudioGamePlay.Instance.PlayEffect(Manager_AudioGamePlay.Instance.effect_SpeedUp);

        if (Parameter_Manager.Instance.current_Stamina >= stamina_NeedPlsSpeed && isPlus == true)
        {
            Parameter_Manager.Instance.current_Stamina -= stamina_NeedPlsSpeed;     

            Parameter_Manager.Instance.speedPlayer += plus_Speed;
            equal += Parameter_Manager.Instance.plusSpeed;

            UpdateUI();
        }
    }


    private void UpdateUI() // Update Ui Speed and Stamina
    {
        stamina_Bar.UpdateStaminaBar(Parameter_Manager.Instance.current_Stamina, Parameter_Manager.Instance.full_Stamina);
        clock_Speed.CurrentSpeed(Parameter_Manager.Instance.speedPlayer); // change the text current speed
        stamina_Bar.CurrentStamina(Parameter_Manager.Instance.current_Stamina); // change the text current stamina
    }

    private IEnumerator BackToNormalSpeed() // set speed back to normal speedPlayer
    {
        yield return new WaitForSeconds(time);

        Parameter_Manager.Instance.speedPlayer -= equal;
        clock_Speed.CurrentSpeed(Parameter_Manager.Instance.speedPlayer);     
    }
}
