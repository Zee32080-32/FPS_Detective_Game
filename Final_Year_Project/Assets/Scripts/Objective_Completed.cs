using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Objective_Completed : MonoBehaviour
{
    [SerializeField]
    private bool DisableObjectiveAlert;
    [SerializeField]
    Activate_Text Activate_Text;
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
        if (Activate_Text.DialogueFinished == true && TextPanel.activeSelf == false)
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
