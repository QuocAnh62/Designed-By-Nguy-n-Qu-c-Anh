using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PickUpCarrot : MonoBehaviour
{
    public List<GameObject> carrot = new List<GameObject>();
    public Image targetImage;
    private int maxCarrot;
    private int isRespawn;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Carrot(Clone)")
        {
            if (maxCarrot < 8)
            {
                SystemAudioGamePlay.instance.PlayEffect(SystemAudioGamePlay.instance.effect_PickUp); // Play sound Effect

                carrot.Add(other.gameObject);
                OnOffScriptsUpDown.instance.InActiveScripts(carrot);

                maxCarrot++;
                isRespawn++;
            }
            else return;            
        }

        if(other.gameObject.name == "All Baby Rabbit")
        {
            SystemCoreGame.instance.Refill_UIBar(maxCarrot * 1.5f); // Plus FillAmount UI Circle Full at GameObject Circal Emtpy

            PlayEffectFeedCarrot(); // function play effect when play have pickup Carrot

            DisableCarrot();
            Respawns(); // Respawn carrot 

            maxCarrot = 0; // if player pickUp 8 carot will reset max carrot = 0
        }
    }

    private void Update()
    {
        CarrotFollowPlayer();
    }

    private void CarrotFollowPlayer()
    {
        for (int i = 0; i < carrot.Count; i++)
        {
            carrot[i].transform.position = this.transform.position + new Vector3(0, i + 1f, 0) ;
        }
    }

   


    private void DisableCarrot() // If the player feeds the rabbit then SetActive false carrot
    {
        foreach (GameObject carot in carrot)
        {
            carot.SetActive(false);
        }
        carrot.Clear();
    }

    private void Respawns() // Respawn carrot 
    {      
        if (isRespawn > 10)
        {
            OnOffScriptsUpDown.instance.ActiveScripts(); // this function do set enable true scripts AnimationUpDown
            SpawnCarrot.instance.RespawnCarrot();           
            isRespawn = 0;
        }
        else return;
    }  

    private void PlayEffectFeedCarrot()
    {
        if(maxCarrot > 0)
        {
            SystemAudioGamePlay.instance.PlayEffect(SystemAudioGamePlay.instance.effect_Goal);
        }
    }

}
