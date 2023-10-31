using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Activate_Long_Answer_For_Question : MonoBehaviour
{
    private bool InZone;
    [SerializeField]
    Player_Dialogue_Manager[] Player_Dialogue_Manager;
    private bool OutOfRange;
    public bool[] DialogueFinished;
    [SerializeField]
    private TMP_Text NPCPanelText;
    [SerializeField]
    private TMP_Text Name;
    public GameObject NPCPanel;
    [SerializeField]
    private string[] textLines_Ans1;
    [SerializeField]
    private string[] textLines_Ans2;
    [SerializeField]
    private int index;
    [SerializeField]
    private int[] VL_index;

    [SerializeField]
    private AudioClip[] VoiceLineArray;
    [SerializeField]
    private AudioSource VoiceLine;
    private bool SoundPlayed;
    //[SerializeField]
    //Activate_Text Activate_Text;
    [SerializeField]
    bool Q1_Answered;
    [SerializeField]
    bool Q2_Answered;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Player_Dialogue_Manager[0].Option_1_Selected == true &&  DialogueFinished[0] == false)
        {
            Name.GetComponent<TMP_Text>().text = "Lea Sitkin";
            if (index < textLines_Ans1.Length)
            {
                //NPCPanel.SetActive(true);
                NPCPanelText.GetComponent<TMP_Text>().text = textLines_Ans1[index];

                if (Input.GetKeyDown(KeyCode.F) && DialogueFinished[0] == false)
                {
                    PlayVoiceLines(VL_index[0]);
                    NPCPanelText.GetComponent<TMP_Text>().text = textLines_Ans1[index];
                    VL_index[0]++;
                    index++;

                }

            }

            if (index == 2)
            {                
                DialogueFinished[0] = true;
                //Activate_Text.PlayerIsAskingQuestion = false;
                NPCPanel.SetActive(false);
                index = 0;
                VL_index[0] = 0;
                VL_index[1] = 1;

            }
        }
        if (Player_Dialogue_Manager[1].Option_2_Selected == true && DialogueFinished[1] == false)
        {
            Name.GetComponent<TMP_Text>().text = "Lea Sitkin";
            if (index < textLines_Ans2.Length)
            {
                //NPCPanel.SetActive(true);
                NPCPanelText.GetComponent<TMP_Text>().text = textLines_Ans2[index];

                if (Input.GetKeyDown(KeyCode.F) && DialogueFinished[1] == false)
                {
                    PlayVoiceLines(VL_index[1]);
                    NPCPanelText.GetComponent<TMP_Text>().text = textLines_Ans2[index];
                    VL_index[1]++;
                    index++;

                }

            }

            if (index == 4)
            {
                DialogueFinished[1] = true;
               // Activate_Text.PlayerIsAskingQuestion = false;
                NPCPanel.SetActive(false);
                index = 0;
                VL_index[0] = 0;
                VL_index[1] = 1;


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
