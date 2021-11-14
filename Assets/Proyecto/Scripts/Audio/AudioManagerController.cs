using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManagerController : MonoBehaviour
{

    public Sound[] audios;

    void Awake()
    {
        foreach(Sound a in audios)
        {
            a.source = gameObject.AddComponent<AudioSource>();

            a.source.clip = a.clip;

            a.source.volume = a.volume;
            a.source.pitch = a.pitch;
            a.source.loop = a.loop;

        }
    }

    private void Start()
    {
        AudioPlay("MainTheme"); //Musica de fondo    
    }

    public void AudioPlay(string name)
    {
        Sound a = Array.Find(audios, audio => audio.name == name);
        if (a == null)
        {
            Debug.Log("Audio not found");
            return;
        }
        a.source.Play();
    }
}
