using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Forensics_Manager : MonoBehaviour
{
    public bool PlayerAskQuestion;
    public GameObject Panel; // your fancy canvas box that holds your text objects
    public TMP_Text NPCPanelText;
    public GameObject NPCPanel;
    [SerializeField]
    private TMP_Text Name;
    //[SerializeField]
    //private string[] textLines;
    [SerializeField]
    Activate_Forensics_Questions Activate_Forensics_Questions;
    [SerializeField]
    private AudioClip[] VoiceLineArray;
    [SerializeField]
    private AudioSource VoiceLine;
    private bool SoundPlayed;
    [SerializeField]
    private int index = 0;
    public bool DialogueFinished;
    [SerializeField]
    Dialogue Dialogue;
    
    //public Text Response;

    // private Detective_Talks Detective_Talks;


    ///public TextAsset textFile; //text asset is a block of a text
    //public string[] textLines;
    public bool HideOption3TextPanel;
    public bool HideOption4TextPanel;

    public bool Option_3_Selected;
    public bool Option_4_Selected;
    public bool Option_5_Selected;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Option_3_SelectedTrue()
    {
        PlayerAskQuestion = true;
        Option_3_Selected = true;
        HideOption3TextPanel = true;
        Panel.SetActive(false);
        Dialogue.Panel.SetActive(true);
        Dialogue.NameText.GetComponent<TMP_Text>().color = new Color32(250, 191, 74, 255);
        Dialogue.TextBox.GetComponent<TMP_Text>().color = new Color32(250, 191, 74, 255);
        Dialogue.TextBox.GetComponent<TMP_Text>().text = "I’m certain that she was strangled";
        PlayVoiceLines();
        Dialogue.QA_Panel.SetActive(false);


    }

    public void Option_4_SelectedTrue()
    {
        PlayerAskQuestion = true;
        Option_4_Selected = true;
        HideOption4TextPanel = true;
        Panel.SetActive(false);
        Dialogue.Panel.SetActive(true);
        Dialogue.NameText.GetComponent<TMP_Text>().color = new Color32(250, 191, 74, 255);
        Dialogue.TextBox.GetComponent<TMP_Text>().color = new Color32(250, 191, 74, 255);
        Dialogue.TextBox.GetComponent<TMP_Text>().text = "I have placed her death between 00.00 and 01.00 on 22/09/2019, so not that long after she was taken";

        PlayVoiceLines();
        Dialogue.QA_Panel.SetActive(false);



    }

    public void Option_5_SelectedTrue()
    {
        PlayerAskQuestion = true;
        Option_5_Selected = true;
        Panel.SetActive(false);
        Dialogue.Panel.SetActive(true);
        Dialogue.NameText.GetComponent<TMP_Text>().color = new Color32(250, 191, 74, 255);
        Dialogue.TextBox.GetComponent<TMP_Text>().color = new Color32(250, 191, 74, 255);
        PlayVoiceLines();
        Dialogue.QA_Panel.SetActive(false);
    }
    private void DelayCloseTimer()
    {
        Dialogue.Panel.SetActive(false);


    }

    public void PlayVoiceLines()
    {
        VoiceLine.clip = VoiceLineArray[index];
        VoiceLine.Play();
        index++;

        if (index >= VoiceLineArray.Length)
        {
            index = 0;
            DialogueFinished = true;
            Debug.Log("Dialogue Finshed = " + DialogueFinished);
            
        }
    }
    /*
    public void LoadTextInToTextBoxResponse_3()
    {
        for (int x = 0; x < textLines.Length; x++)
        {
            Debug.Log("For loop Started");
            if (textLines[x].Contains("[Response 3] "))
            {
               // Response.text = textLines[x].Replace("[Response 3] ", "");
                Debug.Log("[Response 3] " + " is found");
            }
        }
    }
    */


}
