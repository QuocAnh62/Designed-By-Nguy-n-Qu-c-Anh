using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_End : MonoBehaviour
{
    public static Menu_End Instance;
 
    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
    }

    private void Awake()
    {
        if(Instance == null) Instance = this;
    }
}
