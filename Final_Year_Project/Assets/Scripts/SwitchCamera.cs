using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwitchCamera : MonoBehaviour
{
    public GameObject FPSCam;
    public GameObject OverheadCam1;
    public GameObject InsideOfCarCam;
    [SerializeField]
    private GameObject Text;
    private bool PlayerInZone;
    Inspect Inspect;
    public float zoom = 20f;
    public float normal = 60f;
    public float smooth = 5f;
    [SerializeField]
    private GameObject Main_Panel;

    [SerializeField]
    private AudioSource Door_Audio_AS;


    private bool Door_Close_Audio_Played;
    private bool isZoomedIn = false;
    private void Start()
    {
        Inspect = FindObjectOfType<Inspect>();
        FPSCam.SetActive(true);
        OverheadCam1.SetActive(false);
        InsideOfCarCam.SetActive(false);
        Text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("1Key"))
        {
            FPSCam.SetActive(true);
            OverheadCam1.SetActive(false);
            InsideOfCarCam.SetActive(false);
            Text.SetActive(false);
            Door_Close_Audio_Played = false;
            Main_Panel.SetActive(true);
        }

    }




}
