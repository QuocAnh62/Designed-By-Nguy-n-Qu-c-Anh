using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Parameter : MonoBehaviour
{
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        setParameter();

        Destroy(this.gameObject, 0.5f);
    }

    private void setParameter()
    {
        if (PlayerPrefs.GetInt("CheckDestroy") <= 0)
        {
            PlayerPrefs.SetInt("Number Car", 9);

            PlayerPrefs.SetFloat("Speed Animal", 13f);
            PlayerPrefs.SetFloat("Speed Zombie", 25f);

            // Player
            PlayerPrefs.SetFloat("Speed Player", 13);
            PlayerPrefs.SetFloat("Stamina", 64);
            PlayerPrefs.SetFloat("Plus Stamina", 2);

            PlayerPrefs.SetInt("CheckDestroy", 1);

        }
    }

}
