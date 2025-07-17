using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTheGame : MonoBehaviour
{
    public GameObject textStart;
    public GameObject textNow;

    private void Start()
    {
        StartCoroutine(StartGame());
    }

    private IEnumerator StartGame()
    {
        yield return new WaitForSeconds(1f);
        textStart.SetActive(false);
        textNow.SetActive(true);
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
