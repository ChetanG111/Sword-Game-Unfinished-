using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound 
{
    
    public AudioClip clip;
    public string name;
    [Range(0f, 1f)]
    public float volume;
    [Range(0f, 3f)]
    public float pitch;

    public bool Loop;

    [HideInInspector]
    public AudioSource audiosource;
    
}
