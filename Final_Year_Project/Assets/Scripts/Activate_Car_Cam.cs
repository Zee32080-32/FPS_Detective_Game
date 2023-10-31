using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Car_Cam : MonoBehaviour
{
    [SerializeField]
    Inspect Inspect;
    [SerializeField]
    private GameObject Main_Panel;
    public GameObject FPSCam;
    public GameObject OverheadCam1;
    public GameObject InsideOfCarCam;
    [SerializeField]
    private AudioSource Door_Audio_AS;
    private bool Door_Close_Audio_Played;
    [SerializeField]
    private GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Inspect>();
    }

    // Update is called once per frame
    void Update()
    {
        if (InsideOfCarCam.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Inspect.InteractInZone = false;
            }
        }

    }

    public void ActivateCam()
    {
        if (Input.GetKeyDown(KeyCode.F) && Inspect.InteractInZone == true)
        {
            FPSCam.SetActive(false);
            OverheadCam1.SetActive(false);
            InsideOfCarCam.SetActive(true);
            Door_Audio_AS.Play();
            Text.SetActive(true);
            Main_Panel.SetActive(false);
        }
    }
}
