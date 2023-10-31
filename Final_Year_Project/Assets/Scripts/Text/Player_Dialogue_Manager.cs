using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using TMPro;
using UnityStandardAssets.Characters.FirstPerson;

public class Player_Dialogue_Manager : MonoBehaviour
{
    public GameObject Panel; // your fancy canvas box that holds your text objects
    public GameObject NPCPanel;
    public GameObject NPCPanel_Text;
    [SerializeField]
    private Activate_Text Activate_Text;
    public Dialogue Dialogue;
    [SerializeField]
    private GameObject Button_1;
    [SerializeField]
    private GameObject Button_2;
    //[SerializeField]
    //private GameObject Option_1_Response;
    //[SerializeField]
    //private GameObject Option_2_Response;

    [SerializeField]
    private AudioClip[] VoiceLineArray;
    [SerializeField]
    private AudioSource VoiceLine;
    private bool SoundPlayed;
    [SerializeField]
    private int index = 0;
    [SerializeField]
    bool DialogueFinished;

    public bool Option_1_Selected;
    public bool Option_2_Selected;

    private void Start()
    {
        Activate_Text.PlayerIsAskingQuestion = true;

        Option_1_Selected = false;
        Option_2_Selected = false;
    }

    private void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.F))
        {
            NPCPanel.SetActive(false);
        }
        */
    }

    private void LoadTextInToTextBoxResponse_2()
    {
        /*
        for (int x = 0; x < textLines.Length; x++)
        {
            Debug.Log("For loop Started");
            if (textLines[x].Contains("[Response 1] "))
            {
                Response.text = textLines[x].Replace("[Response 1] ", "");
                Debug.Log("[Response 1] " + " is found");
                if (Input.GetKeyDown(KeyCode.F))
                {
                    TriggerDialogue();
                }
            }
        }
        */
        PlayVoiceLines();
    }
    private void LoadTextInToTextBoxResponse_1()
    {

        PlayVoiceLines();

    }

    public void Option_1_SelectedTrue()
    {
        Option_1_Selected = true;
        Panel.SetActive(false);
        NPCPanel.SetActive(true);
        LoadTextInToTextBoxResponse_1();

        Dialogue.QA_Panel.SetActive(false);
       

    }
    public void Option_2_SelectedTrue()
    {
        Option_2_Selected = true;
        Panel.SetActive(false);
        NPCPanel.SetActive(true);
        LoadTextInToTextBoxResponse_2();
        Dialogue.QA_Panel.SetActive(false);
      
   
    }

    public void PlayVoiceLines()
    {
        VoiceLine.clip = VoiceLineArray[index];
        VoiceLine.Play();
        index++;

        if (index >= VoiceLineArray.Length)
        {
            index = 0;

        }
    }








}
