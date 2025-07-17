using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Zombie : Zombie_Moving
{
    public GameObject menu_Lose;

    [SerializeField] private List<GameObject> inActive;

    public void InactiveSomeUI()
    {
        foreach (GameObject go in inActive)
        {
            go.SetActive(false);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            menu_Lose.SetActive(true);
            InactiveSomeUI();
            Manager_AudioGamePlay.Instance.PlayEffect(Manager_AudioGamePlay.Instance.effect_Fail);
        }
    }
}
