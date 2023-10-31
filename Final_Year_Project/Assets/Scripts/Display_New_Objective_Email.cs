using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display_New_Objective_Email : MonoBehaviour
{
    [SerializeField]
    private GameObject[] NewObjective;

    public bool NewObjectiveHasBeenAdded;
    [SerializeField]
    private Display_UI_With_Key_Press Display_UI_With_Key_Press;
    [SerializeField]
    private bool DisableObjectiveAlert;
    [SerializeField]
    bool AllDialogueComplete;
    [SerializeField]
    private GameObject NewObjectAlert;
    [SerializeField]
    private AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {

        AudioSource AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Display_UI_With_Key_Press.DisplayedObject == true && DisableObjectiveAlert == false)
        {
            Display_Objective();
            DisplayObjectiveAlert();
            Invoke("HideObjectiveAlert", 3f);
        }


    }

    private void Display_Objective()
    {

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
