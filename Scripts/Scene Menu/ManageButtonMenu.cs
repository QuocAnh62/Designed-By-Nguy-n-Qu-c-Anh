using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageButtonMenu : MonoBehaviour
{
    [SerializeField] private GameObject menuLose;
    public void Play()
    {
        SystemAudio.instance.PlayEffect(SystemAudio.instance.button_Effect); // Play effect button
         SceneManager.LoadScene("GamePlay");
        Time.timeScale = 1;
    }

    public void Option()
    {
        SystemAudio.instance.PlayEffect(SystemAudio.instance.button_Effect); // Play effect button
        menuLose.SetActive(true); // Turn on Menu Option
    }

    public void Quit()
    {
        SystemAudio.instance.PlayEffect(SystemAudio.instance.button_Effect); // Play effect button
        Application.Quit();
    }
}
