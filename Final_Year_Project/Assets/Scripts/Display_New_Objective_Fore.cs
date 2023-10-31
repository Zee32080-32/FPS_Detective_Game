using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display_New_Objective_Fore : MonoBehaviour
{
    [SerializeField]
    private GameObject[] NewObjective;

    public bool NewObjectiveHasBeenAdded;
    [SerializeField]
    private Activate_Forensics_Questions Activate_Forensics_Questions;
    [SerializeField]
    private bool DisableObjectiveAlert;
    [SerializeField]
    private GameObject TextPanel;

    [SerializeField]
    private GameObject NewObjectAlert;
    [SerializeField]
    private AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
       
        AudioSource AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Activate_Forensics_Questions.DialogueFinished == true && DisableObjectiveAlert == false)
        {
            if (TextPanel.activeSelf == false)
            {
                Display_Objective();
                DisplayObjectiveAlert();
                Invoke("HideObjectiveAlert", 3f);
            }



        }
    }

    private void Display_Objective()
    {

        NewObjective[0].SetActive(true);
        for (int x = 0; x >= NewObjective.Length; x++)
        {
            Debug.Log("The index is " + x);
            NewObjective[x].SetActive(true);
            //Debug.Log("The index is " + x);

        }



    }

    private void DisplayObjectiveAlert()
    {
        AS.Play();
        NewObjectAlert.SetActive(true);

    }

    private void HideObjectiveAlert()
    {
        NewObjectAlert.SetActive(false);
        DisableObjectiveAlert = true;
    }

}
