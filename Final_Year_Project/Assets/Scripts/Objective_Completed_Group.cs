using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Objective_Completed_Group : MonoBehaviour
{
    [SerializeField]
    private bool DisableObjectiveAlert;
    [SerializeField]
    Activate_Text Activate_Text_1;
    [SerializeField]
    Activate_Text Activate_Text_2;
    [SerializeField]
    Activate_Text Activate_Text_3;
    [SerializeField]
    Activate_Text Activate_Text_4;
    [SerializeField]
    Activate_Text Activate_Text_5;
    [SerializeField]
    private GameObject TextPanel;
    [SerializeField]
    private GameObject[] Objective_CompletedArray;
    public bool Is_Objective_Completed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Activate_Text_1.DialogueFinished == true && Activate_Text_2.DialogueFinished == true && Activate_Text_3.DialogueFinished == true && Activate_Text_4.DialogueFinished == true && Activate_Text_5.DialogueFinished == true)
        {
            if(TextPanel.activeSelf == false)
            {
                ObjectiveComplete();
                Is_Objective_Completed = true;

            }


            
        }
    }

    private void ObjectiveComplete()
    {
        for (int x = 0; x < Objective_CompletedArray.Length; x++)
        {
            Objective_CompletedArray[x].GetComponent<TMP_Text>().fontStyle = FontStyles.Strikethrough;


        }
    }
}
