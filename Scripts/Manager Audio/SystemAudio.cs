using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemAudio : MonoBehaviour
{
    public static SystemAudio instance;

    [Header("------- Audio Source -------")]
    [SerializeField] protected AudioSource musicSource;
    [SerializeField] protected AudioSource effectSource;

    [Header("------- Audio Back Ground -------")]
    public AudioClip music_BG_SecenStart;
    public AudioClip button_Effect;

    private void Awake()
    {
        if (instance == null) { instance = this; }
    }

    private void Start()
    {
        musicSource.clip = music_BG_SecenStart;
        musicSource.Play();
    }

    private void Update()
    {
        AllowPlayMusic();
        AllowPlayEffect();
    }


    public void PlayEffect(AudioClip clip)
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
