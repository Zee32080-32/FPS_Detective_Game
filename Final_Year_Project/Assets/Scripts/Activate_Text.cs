using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Activate_Text : MonoBehaviour
{
    public TextAsset TextFileAsset; // your imported text file for your NPC
    private Queue<string> dialogue = new Queue<string>(); // stores the dialogue (Great Performance!)
    public bool dialogueTiggered;
    private bool PlayerInZone;
    public Dialogue Dialogue;
    [SerializeField]
    private AudioClip[] VoiceLineArray;
    [SerializeField]
    private AudioSource VoiceLine;
    private bool SoundPlayed;
    [SerializeField]
    private int index = 0;
    public bool DialogueFinished;
    Inspect Inspect;
    //public TMP_Text Objective;
    public bool PlayerIsAskingQuestion = false;

    void Start()
    {
        Inspect = FindObjectOfType<Inspect>();
        PlayerInZone = false;
        dialogueTiggered = false;
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) && PlayerInZone == true && PlayerIsAskingQuestion == false)
        {
            Debug.Log("Key is pressed");
            TriggerDialogue();
            dialogueTiggered = true;
            if (DialogueFinished == false)
            {
                PlayVoiceLines();
            }

        }
        

    }
    public void TriggerDialogue()
    {
        ReadTextFile(); // loads in the text file
        Dialogue.StartDialogue(dialogue); // Accesses Dialogue Manager and Starts Dialogue


        Debug.Log("TriggerDialogue has been called display text");
    }

    /* loads in your text file */
    private void ReadTextFile()
    {
        string txt = TextFileAsset.text;

        string[] lines = txt.Split(System.Environment.NewLine.ToCharArray()); // Split dialogue lines by newline

        foreach (string line in lines) // for every line of dialogue
        {
            if (!string.IsNullOrEmpty(line))// ignore empty lines of dialogue
            {
                if (line.StartsWith("[")) // e.g [NAME=Michael] Hello, my name is Michael
                {
                    string special = line.Substring(0, line.IndexOf(']') + 1); // special = [NAME=Michael]
                    string curr = line.Substring(line.IndexOf(']') + 1); // curr = Hello, ...
                    dialogue.Enqueue(special); // adds to the dialogue to be printed
                    dialogue.Enqueue(curr);
                }
                else
                {
                    dialogue.Enqueue(line); // adds to the dialogue to be printed
                }
            }
        }
        dialogue.Enqueue("EndQueue");
        //Debug.Log("Hello");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if (other.tag == "Player")
        {
            PlayerInZone = true;
            Debug.Log("PlayerInZone = true");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Collision");
        if (other.tag == "Player")
        {
            PlayerInZone = false;
            Dialogue.Panel.SetActive(false);
            Debug.Log("PlayerInZone = false");
        }
    }

    public void PlayVoiceLines()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            VoiceLine.clip = VoiceLineArray[index];
            VoiceLine.Play();
            index++;

        }
        if (index >= VoiceLineArray.Length)
        {
            index = 0;
            DialogueFinished = true;
            Debug.Log("Dialogue Finshed = " + DialogueFinished);
            //Objective.fontStyle = FontStyles.Strikethrough;
        }
    }

}