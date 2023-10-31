using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ask_Next_Question : MonoBehaviour
{
    [SerializeField]
    Player_Dialogue_Manager[] Player_Dialogue_Manager;
    [SerializeField]
    Dialogue Dialogue;
    [SerializeField]
    private GameObject NPC_Panel;
    [SerializeField]
    private GameObject Button_1;
    [SerializeField]
    private GameObject Button_2;
    [SerializeField]
    Activate_Text Activate_Text;
    [SerializeField]
    GameObject Disable_Activate_Text;
    [SerializeField]
    bool PlayerAskedQuestion_1;
    [SerializeField]

    bool PlayerAskedQuestion_2;
    // Start is called before the first frame update
    [SerializeField]
    Activate_Long_Answer_For_Question Activate_Long_Answer_For_Question;
    void Start()
    {
       
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Activate_Long_Answer_For_Question.DialogueFinished[0] == true && Activate_Long_Answer_For_Question.DialogueFinished[1] == true)
        {

            Player_Dialogue_Manager[0].Option_1_Selected = false;
            Player_Dialogue_Manager[1].Option_2_Selected = false;
            Activate_Long_Answer_For_Question.DialogueFinished[0] = false;
            Activate_Long_Answer_For_Question.DialogueFinished[1] = false;

            Dialogue.QA_Panel.SetActive(false);
            NPC_Panel.SetActive(true);
            Activate_Text = Disable_Activate_Text.GetComponent<Activate_Text>();
            Activate_Text.enabled = (true);
            Activate_Text.PlayerIsAskingQuestion = false;

        }
        else if (Player_Dialogue_Manager[0].Option_1_Selected == true && Activate_Long_Answer_For_Question.DialogueFinished[0] == true)
        {

                //NPC_Panel.SetActive(false);
                Button_1.SetActive(false);
                Button_2.SetActive(true);
                Activate_Text = Disable_Activate_Text.GetComponent<Activate_Text>();
                Activate_Text.enabled = (false);
                PlayerAskedQuestion_1 = true;
                Dialogue.QA_Panel.SetActive(true);

                

        }
        else if (Player_Dialogue_Manager[1].Option_2_Selected == true && Activate_Long_Answer_For_Question.DialogueFinished[1] == true)
        {

                //NPC_Panel.SetActive(false);
                Button_2.SetActive(false);
                Button_1.SetActive(true);
                Activate_Text = Disable_Activate_Text.GetComponent<Activate_Text>();
                Activate_Text.enabled = (false);
                PlayerAskedQuestion_2 = true;
                Dialogue.QA_Panel.SetActive(true);


        }
    }
}
