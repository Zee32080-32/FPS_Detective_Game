using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Objective_Completed_Forensics : MonoBehaviour
{
    [SerializeField]
    private bool DisableObjectiveAlert;
    [SerializeField]
    Activate_Forensics_Questions Activate_Forensics_Questions;
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
        if (Activate_Forensics_Questions.DialogueFinished == true && TextPanel.activeSelf == false)
        {
            ObjectiveComplete();
            Is_Objective_Completed = true;


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
