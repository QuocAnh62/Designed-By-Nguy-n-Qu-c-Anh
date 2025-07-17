using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemAudioGamePlay : MonoBehaviour
{
    public static SystemAudioGamePlay instance;
    [Header("------- Audio Source -------")]
    [SerializeField] protected AudioSource musicSource;
    [SerializeField] protected AudioSource effectSource;

    [Header("------- Audio Back Ground -------")]
    public AudioClip music_BG_SecenStartGamePlay;
    public AudioClip effect_Goal;
    public AudioClip effect_PickUp;
    public AudioClip button_Effect;
    public AudioClip Effect_Fail;
    void Awake()
    {
        if (instance == null) { instance = this; }
    }


    private void Start()
    {
        AllowPlayMusic();
        AllowPlayEffect();

        musicSource.clip = music_BG_SecenStartGamePlay;
        musicSource.Play();
    }

    public void PlayEffect(AudioClip clip) // That function on Scripts: PickUPCarrot,
    {
        effectSource.PlayOneShot(clip);
    }

    public void AllowPlayMusic()
    {
        if (PlayerPrefs.GetInt("Mute Music") <= 0) musicSource.mute = false;

        else musicSource.mute = true;
    }

    public void AllowPlayEffect()
    {
        if (PlayerPrefs.GetInt("Mute Effect") <= 0) effectSource.mute = false;

        else effectSource.mute = true;
    }
}
