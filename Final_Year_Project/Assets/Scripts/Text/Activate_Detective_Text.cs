using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Activate_Detective_Text : MonoBehaviour
{

    public Detective_Talks Detective_Talks;
    public bool DetectiveInZone;
    Inspect Inspect;
    // Start is called before the first frame update
    void Start()
    {
        Inspect = FindObjectOfType<Inspect>();
        //Detective_Talks = FindObjectOfType<Detective_Talks>();
        DetectiveInZone = false;

    }

    // Update is called once per frame
    public void Update()
    {

        if (DetectiveInZone == true && Detective_Talks.DetectiveIsTalking && Inspect.StartInterrogation == true)
        {

            //CallText();
           // Debug.Log("Method is being Called");

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            DetectiveInZone = true;
            Detective_Talks.DetectiveIsTalking = true;
            Debug.Log("DetectiveInZone = true");
        }
    }

    public void CallText()
    {

            Detective_Talks.DetectiveTalks();
            Detective_Talks.DetectiveIsTalking = false;
        
    }



}
