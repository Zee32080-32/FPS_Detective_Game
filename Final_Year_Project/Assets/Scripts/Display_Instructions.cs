using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Display_Instructions : MonoBehaviour
{
    [SerializeField]
    private Button Button;
    [SerializeField]
    private Button ButtonCross;

    [SerializeField]
    private bool ButtonDisplayedOnce;
    [SerializeField]
    private GameObject InstructionPanel;
    // Start is called before the first frame update
    void Start()
    {
        Button = Button.GetComponent<Button>();
        ButtonCross = ButtonCross.GetComponent<Button>();

    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonDisplayedOnce == false)
        {
            Button.onClick.AddListener(Display);
        }
        else if (ButtonDisplayedOnce == true)
        {

            Hide();
        }
        ButtonCross.onClick.AddListener(ButtonDisplayOnceActive) ;
        

    }

    private void Display()
    {
        InstructionPanel.SetActive(true);
       
    }
    private void Hide()
    {
        InstructionPanel.SetActive(false);
       
    }
    private void ButtonDisplayOnceActive()
    {
        ButtonDisplayedOnce = true;
    }
}
