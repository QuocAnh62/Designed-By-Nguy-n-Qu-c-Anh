using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateUI_Text : MonoBehaviour
{
    [SerializeField] TMP_Text text_Stamina;
    [SerializeField] TMP_Text text_StaminaBar;
    [SerializeField] TMP_Text text_Speed;
    [SerializeField] TMP_Text text_ClockSpeed;

    private void Start()
    {
        ShowTextStaminaBar();
        ShowTextStamina_Speed();
    }

    public void ShowTextStaminaBar()
    {
        text_StaminaBar.text = 
            PlayerPrefs.GetFloat("Stamina").ToString() + "/" + PlayerPrefs.GetFloat("Stamina").ToString();

        text_Stamina.text = PlayerPrefs.GetFloat("Stamina").ToString();
    }
    public void ShowTextStamina_Speed()
    {      
        float a = PlayerPrefs.GetFloat("Speed Player");
        var result = (Mathf.Round(a * 100)) / 100.0; // calculate to take 1 decimal place

        text_Speed.text = result.ToString();
        text_ClockSpeed.text = result.ToString();
    }
}
