using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class StaminaBar : MonoBehaviour
{
    [SerializeField] private Image full_StaminaBar;
    [SerializeField] TMP_Text current_Stamina;
    [SerializeField] TMP_Text full_Stamina;
    private float time_Plus; // this is time cool down plus Stamina 


    private void Start()
    {
        UpdateStaminaBar(PlayerPrefs.GetFloat("Stamina"), PlayerPrefs.GetFloat("Stamina"));
        UpdateTextStamina(PlayerPrefs.GetFloat("Stamina"), PlayerPrefs.GetFloat("Stamina"));
        time_Plus = Parameter_Manager.Instance.time_PlusStamina;
    }

    private void FixedUpdate()
    {
        ManagerPlusStamina();
    }

    public void UpdateStaminaBar(float currentStamina, float maxStamina)
    {
        full_StaminaBar.fillAmount = currentStamina / maxStamina;
    }

    public void UpdateTextStamina(float currentStamina, float maxStamina)
    {
        current_Stamina.text = currentStamina.ToString();
        full_Stamina.text = maxStamina.ToString();
    }


    public void CurrentStamina(float stamina)
    {
        current_Stamina.text = stamina.ToString();
    } 


    private void ManagerPlusStamina()
    {
        time_Plus -= Time.deltaTime;
        if(time_Plus <= 0)
        {
            PlusStamina();
            time_Plus = 1f;
        }
    }

    private void PlusStamina()
    {
        if (Parameter_Manager.Instance.current_Stamina < Parameter_Manager.Instance.full_Stamina)
        {
            float stamina = Parameter_Manager.Instance.current_Stamina += Parameter_Manager.Instance.speedPlayer;
            NotGreater_MaxStamina(stamina);
        }
    }

    private void NotGreater_MaxStamina(float stamina)
    {
        if(stamina < Parameter_Manager.Instance.full_Stamina)
        {
            CurrentStamina(stamina);
            UpdateStaminaBar(stamina, Parameter_Manager.Instance.full_Stamina);
        }
        else
        {
            CurrentStamina(Parameter_Manager.Instance.full_Stamina);
            UpdateStaminaBar(stamina, Parameter_Manager.Instance.full_Stamina);
        }
    }
  
}
