using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerUprate : SystemSpeed_PlusMoney
{ 
   
    protected void PLus_Speed()
    {
        float plus_Speed = PlayerPrefs.GetFloat("Speed Player") + 0.4f;     
        PlayerPrefs.SetFloat("Speed Player", plus_Speed);
 
    }
    protected void PLus_Stamina()
    {

        float equal = PlayerPrefs.GetFloat("Plus Stamina");
        equal += 1;
        PlayerPrefs.SetFloat("Plus Stamina", equal);

        float plus_Stamina = PlayerPrefs.GetFloat("Stamina") + equal;
        PlayerPrefs.SetFloat("Stamina", plus_Stamina);
    }
}
