using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityStandardAssets.Characters.FirstPerson;
public class Dialogue : MonoBehaviour
{
    public GameObject Panel; // your fancy canvas box that holds your text objects
    public GameObject QA_Panel;
    public bool QA_Panel_IsActive;
    public GameObject CanvasBox; // your fancy canvas box that holds your text objects
    public TMP_Text NameText; // the text body of the name you want to display
    public TMP_Text TextBox; // the text body
    public bool ConversationDone;
    public Queue<string> inputStream = new Queue<string>(); // stores dialogue
    public bool Activate_WebLink;

    Inspect Inspect;
    [SerializeField]
    Activate_Text Activate_Text;
    private void Start()
    {
        CanvasBox.SetActive(false); // close the dialogue box on play
       
        Inspect = FindObjectOfType<Inspect>();
    }

    private void Update()
    {
        //Debug.Log("inputStream.Count = " + inputStream.Count);

    }

    public void StartDialogue(Queue<string> dialogue)
    {


        CanvasBox.SetActive(true); // open the dialogue box
        // isOpen = true;
        inputStream = dialogue; // store the dialogue from dialogue trigger
        PrintDialogue(); // Prints out the first line of dialogue
    }

    public void AdvanceDialogue() // call when a player presses a button in Dialogue Trigger
    {
        PrintDialogue();
    }

    private void PrintDialogue()
    {
        if (inputStream.Peek().Contains("[Player Ask Question]"))
        {
            this.Activate_Text.PlayerIsAskingQuestion = true;
            this.Panel.SetActive(false);
            this.QA_Panel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Activate_WebLink = false;

        }
        else 
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        if (inputStream.Peek().Contains("[Display Web Link]"))
        {
            Activate_WebLink = true;

        }
        if (inputStream.Count == 0 || inputStream.Peek().Contains("EndQueue")) // special phrase to stop dialogue
        {
            inputStream.Dequeue(); // Clear Queue
            EndDialogue();

        }
        else if (inputStream.Peek().Contains("[NAME="))
        {
            string name = inputStream.Peek();
            name = inputStream.Dequeue().Substring(name.IndexOf('=') + 1, name.IndexOf(']') - (name.IndexOf('=') + 1));
            NameText.text = name;
            PrintDialogue(); // print the rest of this line
        }


        else
        {
            TextBox.text = inputStream.Dequeue();
        }
    }

    public void EndDialogue()
    {
        TextBox.text = "";
        NameText.text = "";
        inputStream.Clear();
        CanvasBox.SetActive(false);
        ConversationDone = true;
        
        //Debug.Log("Conversation Done = " + ConversationDone);
        // isOpen = false;

    }
}
