using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioClip jumpClip; // referencia al audio clip
    public AudioSource SFXSource; // referencia al audiosource

    public AudioMixer mixer;
    public Slider masterVolumeSlider;
    public Slider musicSlider;
    public Slider SFXSlider;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SFXSource.clip = jumpClip; // Asignar un clip
            SFXSource.Play(); // Play
        }

        mixer.SetFloat("MasterVolume", masterVolumeSlider.value);
        mixer.SetFloat("MusicVolume", musicSlider.value);
        mixer.SetFloat("SFXVolume", SFXSlider.value);
    }
}
