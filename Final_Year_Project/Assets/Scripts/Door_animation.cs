using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_animation : MonoBehaviour
{
    [SerializeField]
    private Animator Door;
    public bool InZone;
    [SerializeField]
    private bool Door_Open_Audio_Played;
    public bool Door_Is_Open;
    Inspect Inspect;
    [SerializeField]
    private AudioSource Door_Audio_AS;
    [SerializeField]
    private AudioClip Door_Open_Audio;
    [SerializeField]
    private AudioClip Door_Close_Audio;
    private void Start()
    {
        Inspect = FindObjectOfType<Inspect>();
    }

    private void Update()
    {
        /*

        if (Inspect.PlayerIsCollidingWithDoor == true && Input.GetKeyDown(KeyCode.F))
        {
            PlayDoorOpen();
            Play_Door_Open_Audio();
        }
        else if (InZone == false)
        {
            PlayDoorClose();
            if (this.Door.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                Play_Door_Close_Audio();
            }
            
        }
        */
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            InZone = true;

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            InZone = false;

        }

    }
    
    public void PlayDoorOpen()
    {
        Door_Is_Open = true;
        Play_Door_Open_Audio();
        Door.SetBool("Open_Door", true);
    
    }

    public void PlayDoorClose()
    {
        Door.SetBool("Open_Door", false);
        if (this.Door.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            Play_Door_Close_Audio();
        }
       
    }
    
    private void Play_Door_Open_Audio()
    {
        if (Door_Open_Audio_Played == false)
        {
            Door_Audio_AS.clip = Door_Open_Audio;
            Door_Audio_AS.Play();
            Door_Open_Audio_Played = true;
        }

    }

    private void Play_Door_Close_Audio()
    {
        if (Door_Open_Audio_Played == true)
        {
            Door_Audio_AS.clip = Door_Close_Audio;
            Door_Audio_AS.Play();
            Door_Open_Audio_Played = false;
        }

    }



}
