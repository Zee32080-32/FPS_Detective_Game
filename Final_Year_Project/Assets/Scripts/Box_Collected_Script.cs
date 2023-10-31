using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Box_Collected_Script : MonoBehaviour
{
    [SerializeField]
    private bool DisableObjectiveAlert;
    [SerializeField]
    private GameObject[] Objective_CompletedArray;
    public bool Is_Objective_Completed;
    [SerializeField]
    bool In_Zone;

    [SerializeField]
    private GameObject[] NewObjective;

    [SerializeField]
    private GameObject NewObjectAlert;
    [SerializeField]
    private AudioSource AS;
    [SerializeField]
    Display_Map_Button Display_Map_Button;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (In_Zone == true && Input.GetKeyDown(KeyCode.F))
        {
            ObjectiveComplete();
            Is_Objective_Completed = true;

            Display_Objective();
            DisplayObjectiveAlert();
            Invoke("HideObjectiveAlert", 3f);

        }
    }

    private void ObjectiveComplete()
    {
        for (int x = 0; x < Objective_CompletedArray.Length; x++)
        {
            Objective_CompletedArray[x].GetComponent<TMP_Text>().fontStyle = FontStyles.Strikethrough;


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            In_Zone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            In_Zone = false;
        }
    }

    private void Display_Objective()
    {
        Display_Map_Button.UI_Flash = true;
        NewObjective[0].SetActive(true);
        for (int x = 0; x < NewObjective.Length; x++)
        {
            //Debug.Log("The index is " + x);
            NewObjective[x].SetActive(true);
            //Debug.Log("The index is " + x);

        }



    }

    private void DisplayObjectiveAlert()
    {
        AS.Play();
        NewObjectAlert.SetActive(true);

    }

    private void HideObjectiveAlert()
    {
        NewObjectAlert.SetActive(false);
        DisableObjectiveAlert = true;
    }
}
