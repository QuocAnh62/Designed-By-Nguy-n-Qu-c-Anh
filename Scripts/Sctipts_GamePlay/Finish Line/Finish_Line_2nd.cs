using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_Line_2nd : MonoBehaviour
{
    [SerializeField] private GameObject menu_End;

    private void ShowMenuEnd()
    {
        menu_End.SetActive(true);
    }

    private void Harder()
    {
        int plus_car = Parameter_Manager.Instance.number_Car + 1;
        PlayerPrefs.SetInt("Number Car", plus_car);

        float plus_SpeedZombie = Parameter_Zombie.Instance.speedZombie + 2;
        PlayerPrefs.SetFloat("Speed Zombie", plus_SpeedZombie);

        float plus_SpeedAnimal = Parameter_Manager.Instance.speedAnimal + 2;
        PlayerPrefs.SetFloat("Speed Animal", plus_SpeedAnimal);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ShowMenuEnd();
            Harder();
            Manager_AudioGamePlay.Instance.PlayEffect(Manager_AudioGamePlay.Instance.effect_Win);
            Time.timeScale = 0;
        }
    }
}
