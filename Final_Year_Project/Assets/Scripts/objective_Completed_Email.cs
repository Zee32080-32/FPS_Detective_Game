using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class objective_Completed_Email : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Objective_CompletedArray;
    public bool Is_Objective_Completed;
    [SerializeField]
    private bool DisableObjectiveAlert;
    [SerializeField]
    Display_UI_With_Key_Press Display_UI_With_Key_Press;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if (Display_UI_With_Key_Press.DisplayedObject == true)
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
