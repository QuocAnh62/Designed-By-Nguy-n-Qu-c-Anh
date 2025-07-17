using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenuOption : MonoBehaviour
{
    [SerializeField] private GameObject menuLose;

    // Music
    [SerializeField] private GameObject iconOnMusic;
    [SerializeField] private GameObject iconOffMusic;

    // Effect
    [SerializeField] private GameObject iconOnEffect;
    [SerializeField] private GameObject iconOffEffect;

    private void Start()
    {
        ManagerShowOnOffIcon();
    }

    public void CloseOption()
    {
        SystemAudio.instance.PlayEffect(SystemAudio.instance.button_Effect); // Play effect button
        menuLose.SetActive(false);
    }

    // Part Of Music //
    public void ButtonOnMusic()
    {
        PlayerPrefs.SetInt("Mute Music", 1);
        OnOffButton("Music", false, true);
    }

    public void ButtonOffMusic()
    {
        PlayerPrefs.SetInt("Mute Music", 0);
        OnOffButton("Music", true, false);        
    }


    // Part Of Effect //
    public void ButtonOnEffect()
    {
        PlayerPrefs.SetInt("Mute Effect", 1);
        OnOffButton("Effect", false, true);
    }

    public void ButtonOffEffect()
    {
        PlayerPrefs.SetInt("Mute Effect", 0);
        OnOffButton("Effect", true, false);
    }


    private void OnOffButton(string nameButton, bool buttonOn, bool buttonOff)
    {
        SystemAudio.instance.PlayEffect(SystemAudio.instance.button_Effect); // Play effect button
        if (nameButton == "Music")
        {
            iconOnMusic.SetActive(buttonOn);
            iconOffMusic.SetActive(buttonOff);

        }
        else if (nameButton == "Effect")
        {
            iconOnEffect.SetActive(buttonOn);
            iconOffEffect.SetActive(buttonOff);
        }
        else { Debug.LogError("Error on Scripts ButtonMenuOption"); }
    }
  

    private void ManagerShowOnOffIcon()
    {
        if(PlayerPrefs.GetInt("Mute Music") == 0)
        {
            OnOffButton("Music", true, false);
        }
        else if(PlayerPrefs.GetInt("Mute Music") == 1)
        {
            OnOffButton("Music", false, true);
        }

        else if(PlayerPrefs.GetInt("Mute Effect") == 0)
        {
            OnOffButton("Effect", true, false);
        }
        else if (PlayerPrefs.GetInt("Mute Effect") == 1)
        {
            OnOffButton("Effect", false, true);
        }
    }

}
