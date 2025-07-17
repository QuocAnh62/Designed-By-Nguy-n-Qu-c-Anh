using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemCoreGame : MonoBehaviour // this scripts on GameObject Cricle Emtpy (Canvas)
{
    public static SystemCoreGame instance;

    public Image image; 
    [SerializeField] private GameObject menuGameOver;
    public float duration = 20f;

    private float elapsedTime = 0f;
    private float timeStart = 2f;
    private float isMakeEffect;

    private void Awake()
    {
        if (instance == null) { instance = this; }
        Time.timeScale = 1f;
    }

    void Update()
    {
        timeStart -= Time.deltaTime;
        CoreGame();
    }

    private void CoreGame()
    {
        if (timeStart <= 0)
        {
            if (image.fillAmount > 0)
            {
                elapsedTime += Time.deltaTime; 
                image.fillAmount = Mathf.Lerp(1f, 0f, elapsedTime / duration); // calculate minus fillAmount               
            }
            else if (image.fillAmount <= 0)
            {
                MakeSoundEffecFail(); // Function MakeEffect GameOver
                menuGameOver.SetActive(true);
                Time.timeScale = 0f;
            }

            timeStart = 0;
        }
    }


    public void Refill_UIBar(float p)
    {
        if(elapsedTime > 0)
        {
            elapsedTime -= p;
        }
        if(elapsedTime < 0)
        {
            elapsedTime = 0f;
        }
    }

    private void MakeSoundEffecFail()
    {
        if (isMakeEffect <= 0)
        {
            SystemAudioGamePlay.instance.PlayEffect(SystemAudioGamePlay.instance.Effect_Fail);
            isMakeEffect = 1;
        }
        else return;
    }
}
