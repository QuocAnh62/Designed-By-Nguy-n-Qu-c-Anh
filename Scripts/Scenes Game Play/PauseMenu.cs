using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;


    public void ButtonPauseMenu()
    {
        SystemAudioGamePlay.instance.PlayEffect(SystemAudioGamePlay.instance.button_Effect);
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        SystemAudioGamePlay.instance.PlayEffect(SystemAudioGamePlay.instance.button_Effect);
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void ButtonMainMenu()
    {
        SystemAudioGamePlay.instance.PlayEffect(SystemAudioGamePlay.instance.button_Effect);
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        SystemAudioGamePlay.instance.PlayEffect(SystemAudioGamePlay.instance.button_Effect);
        Application.Quit();
    }
}
