using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerButton : ManagerUprate
{
    [SerializeField] private UpdateUI_Text updateUI_Text;
    public void Play()
    {
        SceneManager.LoadScene("GamePlay");
        Manager_Audio.Instance.PlayEffect(Manager_Audio.Instance.effect_Button);
    }

    public void UprateStamina()
    {
        PLus_Stamina();
        updateUI_Text.ShowTextStaminaBar();
        Manager_Audio.Instance.PlayEffect(Manager_Audio.Instance.effect_Button);
    }

    public void UprateSpeed()
    {
        PLus_Speed();
        updateUI_Text.ShowTextStamina_Speed();
        Manager_Audio.Instance.PlayEffect(Manager_Audio.Instance.effect_Button);
    }

    public void Income()
    {
        Debug.Log("Plus Money");
    }

    public void PlusSpeedAndMoney()
    {
        Debug.Log("Speed and Money");
    }

    public void DisADS()
    {
        Debug.Log("Not ADS");
    }
}
