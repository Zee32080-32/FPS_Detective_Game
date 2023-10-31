using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Detective_Talks : MonoBehaviour
{
    public GameObject Panel; // your fancy canvas box that holds your text objects
    public GameObject QA_Panel;
    public bool QA_Panel_IsActive;
    public TMP_Text TextBox;
    public TextAsset textFile; //text asset is a block of a text
    public string[] textLines;
    public bool DetectiveIsTalking;
    public int DialogueCounter = -1;
    public bool EndLoop = false;
    [SerializeField]
    private TMP_Text Name;

    public NPC_Dialogue NPC_Dialogue;
    Player_Dialogue_Manager Player_Dialogue_Manager;

    // Start is called before the first frame update
    void Start()
    {
        //NPC_Dialogue = FindObjectOfType<NPC_Dialogue>();
        //Player_Dialogue_Manager = FindObjectOfType<Player_Dialogue_Manager>();

        if (textFile != null) //makes sure textfile is not empty
        {
            textLines = (textFile.text.Split('\n')); //split the text into seperate pieces
        }

    }



    public void DetectiveTalks()
    {
        DetectiveIsTalking = true;
        EndLoop = false;

        while (DetectiveIsTalking == true && EndLoop == false && QA_Panel_IsActive == false)
        {

            DialogueCounter += 1;

            if (textLines[0].StartsWith("NAME")) // e.g [NAME=Michael] Hello, my name is Michael
            {

                string ClipNameEndOff = textLines[0].Substring(0, 5);
                Name.text = textLines[0].Replace(ClipNameEndOff, "");
                Name.GetComponent<TMP_Text>().color = new Color32(74, 161, 250, 255);
            }

            if (textLines[DialogueCounter].Contains("[End of question "))
            {
                //Debug.Log("[End of question " + "Is Found");
                DetectiveIsTalking = false;
                EndLoop = true;

                string ClipEndOff = textLines[DialogueCounter].Substring(textLines[DialogueCounter].Length - 20);
                TextBox.text = textLines[DialogueCounter].Replace(ClipEndOff, "");
              
                Panel.SetActive(true);
                TextBox.GetComponent<TMP_Text>().color = new Color32(74, 161, 250, 255);
                StartCoroutine(DelayDialogueTime());

            }


            if (textLines[DialogueCounter].Contains("[End discussion]"))
            {
                Panel.SetActive(false);

                EndLoop = true;
                DetectiveIsTalking = false;
               

            }

            if (textLines[DialogueCounter].Contains("[Ask Question]"))
            {
                Panel.SetActive(false);
                QA_Panel.SetActive(true);
                QA_Panel_IsActive = true;

                EndLoop = true;
                DetectiveIsTalking = false;
            }
        }

    }

    public void StopDetectiveTalking()
    {
        NPC_Dialogue.NPCTalks();
    }


    public IEnumerator DelayDialogueTime()
    {

        yield return new WaitForSeconds(5f);
        NPC_Dialogue.NPCIsTalking = true;
        //StopDetectiveTalking();


    }


}
