using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Objective_Completed_CarPark : MonoBehaviour
{
    [SerializeField]
    private bool DisableObjectiveAlert;
    [SerializeField]
    GameObject E1;
    [SerializeField]
    GameObject E2;
    [SerializeField]
    GameObject E3;
    [SerializeField]
    GameObject E4;
    [SerializeField]
    GameObject E5;

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
        if (E1.activeSelf == true && E2.activeSelf == true && E3.activeSelf == true && E4.activeSelf == true && E5.activeSelf == true)
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
