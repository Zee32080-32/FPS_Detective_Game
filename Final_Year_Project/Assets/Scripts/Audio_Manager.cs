using UnityEngine;
using System;
using UnityEngine.Audio;
using System.Collections;

public class Audio_Manager : MonoBehaviour
{
    public Sound[] Sounds;
    public float DelaySec;

    public void Awake()
    {
        foreach (Sound s in Sounds)
        {
            s.Source = gameObject.AddComponent<AudioSource>();
            s.Source.clip = s.Clip;

            s.Source.volume = s.volume;
            s.Source.pitch = s.pitch;

            s.Source.loop = s.loop;
            s.Source.spatialBlend = s.spatialBlend;
         

        }
    }


    public void Play(string Name)
    {
        // Finds a sound in the sound array
        // Finds a Sounds where Sound.Name is the same as Name
        Sound S = Array.Find(Sounds, Sound => Sound.Name == Name);
        S.Source.Play();

    }



    public void Stop(string Name)
    {
        // Finds a sound in the sound array
        // Finds a Sounds where Sound.Name is the same as Name
        Sound S = Array.Find(Sounds, Sound => Sound.Name == Name);
        S.Source.Stop();
        S.Source.loop = false;

    }


}


