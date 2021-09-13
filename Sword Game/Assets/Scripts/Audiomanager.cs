using UnityEngine.Audio;
using System;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
    public static Audiomanager instance;

    public Sound[] sounds;

    private void Awake()

    {
        instance = this;
        foreach (Sound s in sounds)
        {
          s.audiosource =  gameObject.AddComponent<AudioSource>();
            s.audiosource.clip = s.clip;

            s.audiosource.volume = s.volume;
            s.audiosource.pitch = s.pitch;
            s.audiosource.loop = s.Loop;
        }
    }

    private void Start()
    {
        Play("Theme");
    }


    public void Play(string name)
    {
       Sound s =  Array.Find(sounds, sound => sound.name == name);
        if (s == null)
            return;
        s.audiosource.Play();
    }

    
}
