using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Activate_Forensics_Questions : MonoBehaviour
{
    private bool InZone;
    [SerializeField]
    Forensics_Manager[] Forensics_Manager;
    private bool OutOfRange;
    public bool DialogueFinished;
    public TMP_Text NPCPanelText;
    public TMP_Text Name;
    public GameObject NPCPanel;
    [SerializeField]
    private string[] textLines_Ans3;
    [SerializeField]
    private int index;
    [SerializeField]
    private int[] VL_index;
    [SerializeField]
    Dialogue Dialogue;

    [SerializeField]
    private AudioClip[] VoiceLineArray;
    [SerializeField]
    private AudioSource VoiceLine;
    private bool SoundPlayed;
    //[SerializeField]
    //Activate_Text Activate_Text;

    public bool Q1_Answered;
    public bool Q2_Answered;
    public bool Q3_Answered;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Forensics_Manager[0].HideOption3TextPanel == true || Forensics_Manager[1].HideOption4TextPanel == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Dialogue.Panel.SetActive(false);
                Forensics_Manager[0].HideOption3TextPanel = false;
                Forensics_Manager[1].HideOption4TextPanel = false;

            }
        }

        if (Forensics_Manager[2].Option_5_Selected == true && DialogueFinished == false)
        {
            Dialogue.NameText.GetComponent<TMP_Text>().text = "DR GERARD";
            if (index < textLines_Ans3.Length)
            {
                Dialogue.TextBox.GetComponent<TMP_Text>().text = textLines_Ans3[index];

                if (Input.GetKeyDown(KeyCode.F) && DialogueFinished == false)
                {
                    PlayVoiceLines(VL_index[0]);
                    Dialogue.TextBox.GetComponent<TMP_Text>().text = textLines_Ans3[index];
                    VL_index[0]++;
                    index++;

                }

            }

            if (index == 3)
            {
                DialogueFinished = true;
                // Activate_Text.PlayerIsAskingQuestion = false;
                Dialogue.Panel.SetActive(false);
                Q3_Answered = true;
                index = 0;
                VL_index[0] = 0;


            }

        }




    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            InZone = true;
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            InZone = false;

        }
    }

    public void PlayVoiceLines(int VL_index)
    {
        VoiceLine.clip = VoiceLineArray[VL_index];
        VoiceLine.Play();

        if (VL_index >= VoiceLineArray.Length)
        {
            VL_index = 0;

        }
    }




}
