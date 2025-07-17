using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public void ButtonPlayAgain()
    {
        Time.timeScale = 1;
        SystemAudioGamePlay.instance.PlayEffect(SystemAudioGamePlay.instance.button_Effect);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
