using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASK_Next_Question_Forensics : MonoBehaviour
{
    [SerializeField]
    Forensics_Manager[] Forensics_Manager;
    [SerializeField]
    Dialogue Dialogue;
    [SerializeField]
    private GameObject NPC_Panel;
    [SerializeField]
    private GameObject Button_1;
    [SerializeField]
    private GameObject Button_2;
    [SerializeField]
    private GameObject Button_3;
    [SerializeField]
    Activate_Text Activate_Text;
    [SerializeField]
    GameObject Disable_Activate_Text;
    [SerializeField]
    bool PlayerAskedQuestion_1;
    [SerializeField]
    bool PlayerAskedQuestion_2;
    [SerializeField]
    bool PlayerAskedQuestion_3;
    // Start is called before the first frame update
    [SerializeField]
    Activate_Forensics_Questions Activate_Forensics_Questions;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Activate_Forensics_Questions.DialogueFinished == true && Forensics_Manager[0].Option_3_Selected == true && Forensics_Manager[1].Option_4_Selected == true)
        {
            Dialogue.QA_Panel.SetActive(false);
            Activate_Text = Disable_Activate_Text.GetComponent<Activate_Text>();
            Activate_Text.enabled = (true);
            Activate_Text.PlayerIsAskingQuestion = false;

        }
        else if (Forensics_Manager[0].Option_3_Selected == true)
        {

            //NPC_Panel.SetActive(false);
            Button_1.SetActive(false);
            Button_2.SetActive(true);
            Button_3.SetActive(true);
            Activate_Forensics_Questions.Q1_Answered = false;
            Activate_Text = Disable_Activate_Text.GetComponent<Activate_Text>();
            Activate_Text.enabled = (false);
            PlayerAskedQuestion_1 = true;
            Dialogue.QA_Panel.SetActive(true);



        }
        else if (Forensics_Manager[1].Option_4_Selected == true)
        {

            //NPC_Panel.SetActive(false);
            Button_1.SetActive(true);
            Button_2.SetActive(false);
            Button_3.SetActive(true);
            Activate_Forensics_Questions.Q2_Answered = false;
            Activate_Text = Disable_Activate_Text.GetComponent<Activate_Text>();
            Activate_Text.enabled = (false);
            PlayerAskedQuestion_2 = true;
            Dialogue.QA_Panel.SetActive(true);


        }

        else if (Forensics_Manager[2].Option_5_Selected == true && Activate_Forensics_Questions.DialogueFinished == true)
        {

            //NPC_Panel.SetActive(false);
            Button_2.SetActive(true);
            Button_1.SetActive(true) ;
            Button_3.SetActive(false);
            Activate_Forensics_Questions.Q3_Answered = false;
            Activate_Text = Disable_Activate_Text.GetComponent<Activate_Text>();
            Activate_Text.enabled = (false);
            PlayerAskedQuestion_3 = true;
            Dialogue.QA_Panel.SetActive(true);


        }
    }
}
