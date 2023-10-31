using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Objective_Completed_Two : MonoBehaviour
{
    [SerializeField]
    private bool DisableObjectiveAlert;
    [SerializeField]
    Display_Note_Pad_Evidence[] Display_Note_Pad_Evidence;
    [SerializeField]
    private GameObject TextPanel;
    [SerializeField]
    bool[] evidenceCollectedBool;
    [SerializeField]
    Activate_Text[] Activate_Text;

    public bool Is_Objective_Completed;
    [SerializeField]
    private GameObject[] Objective_CompletedArray;
    [SerializeField]
    GameObject NewObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int x = 0; x < evidenceCollectedBool.Length; x++)
        {
            if (Display_Note_Pad_Evidence[x].EvidenceCollected == true)
            {
                evidenceCollectedBool[x] = true;

                if (IsAllTrue(evidenceCollectedBool))
                {
                    ObjectiveComplete();
                    Is_Objective_Completed = true;
                }
            }


          

        }



    }

    private void ObjectiveComplete()
    {
        for (int x = 0; x < Objective_CompletedArray.Length; x++)
        {
            Debug.Log("Method has been called");
            Objective_CompletedArray[x].GetComponent<TMP_Text>().fontStyle = FontStyles.Strikethrough;
            NewObj.SetActive(true);


        }
    }

    public bool IsAllTrue(bool[] collection)
    {
        for (int x = 0; x < collection.Length; x++)
            if (!collection[x])
            {
                return false;
            }
        return true;
    }

}
