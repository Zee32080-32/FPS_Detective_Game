using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NPC_Dialogue : MonoBehaviour
{
    public GameObject Panel; // your fancy canvas box that holds your text objects
    public TMP_Text TextBox;
    public TextAsset textFile; //text asset is a block of a text
    public string[] textLines;
    public bool NPCIsTalking;
    int DialogueCounter = -1;
    public bool EndLoop = false;
    public Detective_Talks Detective_Talks;
    [SerializeField]
    private TMP_Text Name;

    // Start is called before the first frame update
    void Start()
    {
        //Detective_Talks = FindObjectOfType<Detective_Talks>();
        if (textFile != null) //makes sure textfile is not empty
        {
            textLines = (textFile.text.Split('\n')); //split the text into seperate pieces
        }


    }

    // Update is called once per frame

    public void NPCTalks()
    {
        NPCIsTalking = true;
        EndLoop = false;

        while (NPCIsTalking == true && EndLoop == false && Detective_Talks.QA_Panel_IsActive == false)
        {

            DialogueCounter += 1;

            if (textLines[0].StartsWith("NAME")) // e.g [NAME=Michael] Hello, my name is Michael
            {

                string ClipNameEndOff = textLines[0].Substring(0,5);
                Name.text = textLines[0].Replace(ClipNameEndOff, "");
                Name.GetComponent<TMP_Text>().color = new Color32(250, 191, 74, 255);
            }

            if (textLines[DialogueCounter].Contains("[Answer "))
            {
                NPCIsTalking = false;
                EndLoop = true;

                string ClipEndOff = textLines[DialogueCounter].Substring(textLines[DialogueCounter].Length - 11);
                TextBox.text = textLines[DialogueCounter].Replace(ClipEndOff, "");
               
                Panel.SetActive(true);
                TextBox.GetComponent<TMP_Text>().color = new Color32(250, 191, 74, 255);
                Debug.Log("NPC Dialogue Counter " + DialogueCounter);
                StartCoroutine(DelayDialogueTime());
            }

            if (textLines[DialogueCounter].Contains("[End discussion]"))
            {
                EndLoop = true;
                NPCIsTalking = false;
                Panel.SetActive(false);
                Debug.Log("Discussion Has Finished");
            }


        }

    }
    public void StopNPCTalking()
    {

        Detective_Talks.DetectiveTalks();
        Debug.Log("DetectiveTalks Method Is Called");
    }


    public IEnumerator DelayDialogueTime()
    {
        yield return new WaitForSeconds(5f);
        Detective_Talks.DetectiveIsTalking = true;
        Debug.Log("Detective is talking = " + Detective_Talks.DetectiveIsTalking);
        StopNPCTalking();

    }
}
