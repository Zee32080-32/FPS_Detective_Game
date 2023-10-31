using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Display_New_Objective : MonoBehaviour
{
    [SerializeField]
    private GameObject[] NewObjective;

    public bool NewObjectiveHasBeenAdded;
    [SerializeField]
    private Activate_Text[] Activate_Text;
    [SerializeField]
    private bool DisableObjectiveAlert;
    [SerializeField]
    private GameObject TextPanel;
    [SerializeField]
    bool AllDialogueComplete;
    [SerializeField]
    private GameObject NewObjectAlert;
    [SerializeField]
    private AudioSource AS;
    [SerializeField]
    Display_Map_Button Display_Map_Button;
    // Start is called before the first frame update
    void Start()
    {

        AudioSource AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int x = 0; x < Activate_Text.Length; x++)
        {
            if (Activate_Text[x].DialogueFinished == true && DisableObjectiveAlert == false)
            {
                if (TextPanel.activeSelf == false)
                {
                    Display_Objective();
                    DisplayObjectiveAlert();
                    Invoke("HideObjectiveAlert", 3f);
                }
            }

        }

    }

    private void Display_Objective()
    {
        Display_Map_Button.UI_Flash = true;
        NewObjective[0].SetActive(true);
        for (int x = 0; x < NewObjective.Length; x++)
        {
            //Debug.Log("The index is " + x);
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
