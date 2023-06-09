using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AjustesdeAudio : MonoBehaviour
{

    public Slider music;
    public Slider SFX;
    public Slider master;
    public AudioMixer mixer;

    private void Update ()
    {
        mixer.SetFloat("MasterVolume", master.value);
        mixer.SetFloat("MusicVolume", music.value);
        mixer.SetFloat("SFXVolume", SFX.value);


    }













}
