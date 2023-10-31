using UnityEngine.Audio;
using System;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string Name;
    public AudioClip Clip;

    [Range(0f, 3f)]
    public float volume;

    [Range(0.1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource Source;

    public bool loop;

    [Range(0f, 1f)]
    public float spatialBlend;





}
