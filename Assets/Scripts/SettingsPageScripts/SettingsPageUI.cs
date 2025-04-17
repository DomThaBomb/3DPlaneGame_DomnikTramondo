using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsPageUI : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Slider musicSlider;
    public Slider sfxSlider;

    // Start is called before the first frame update
    void Start()
    {
        OnMusicVolumeChanged();
        OnSFXVolumeChanged();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMusicVolumeChanged()
    {
        float newvolume = musicSlider.value;
        if (newvolume <= 0) 
        {
            newvolume = -80.0f;
        }
        else
        {
            newvolume = Mathf.Log10(newvolume);
            newvolume = newvolume * 20.0f;
            audioMixer.SetFloat("MusicVolume",newvolume);
        }
    }

    public void OnSFXVolumeChanged()
    {
        float newvolume = sfxSlider.value;
        if (newvolume <= 0)
        {
            newvolume = -80.0f;
        }
        else
        {
            newvolume = Mathf.Log10(newvolume);
            newvolume = newvolume * 20.0f;
            audioMixer.SetFloat("SFXVolume", newvolume);
        }
    }
}
