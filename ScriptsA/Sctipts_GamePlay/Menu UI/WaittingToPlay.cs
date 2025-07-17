using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaittingToPlay : MonoBehaviour
{
    [SerializeField] private GameObject button_PlusSpeed;
    [SerializeField] private GameObject joysick;
    [SerializeField] private List<GameObject> wait_321;

    private float time_Ready ;


    private void Start()
    {
        time_Ready = Parameter_Manager.Instance.time_ShowButtonPlusSpeed;

        StartCoroutine(ShowButton_SpeedUp());
        StartCoroutine(Wait321());       
    }    


    private IEnumerator ShowButton_SpeedUp() // show Button Speed Up
    {
        yield return new WaitForSeconds(time_Ready); // After 7 second show button Speed Up
        button_PlusSpeed.SetActive(true);

        yield return new WaitForSeconds(3f); // when it show button SpeedUp after 33 second Inactive button SpeedUp
        button_PlusSpeed.SetActive(false);
        joysick.SetActive(true);              
    }

    private IEnumerator Wait321()
    {
        yield return new WaitForSeconds(time_Ready);

        foreach (GameObject obj in wait_321)
        { 
            obj.SetActive(true);
            yield return new WaitForSeconds(1f);

            foreach(GameObject Obj in wait_321)
            {
                obj.SetActive(false);
            }

        }
    }

}
