using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display_Objectives : MonoBehaviour
{
    //97EBFA
    [SerializeField]
    private Image Objective_Panel;
    [SerializeField]
    private Button Button;
    [SerializeField]
    private bool Objectives_Displayed;
    [SerializeField]
    private GameObject[] Objectives;
    private bool State;

    private float Opacity = 1;
    private float TransparanetOpacity = 0;
    // Start is called before the first frame update
    void Start()
    {
        Button = Button.GetComponent<Button>();
        
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Objectives_Displayed);
    }

    public void DisplayObjectives()
    {
        Objectives_Displayed = true;
        Objective_Panel.GetComponent<Image>().color = new Color(Objective_Panel.color.r, Objective_Panel.color.g, Objective_Panel.color.b, Opacity);
        for (int x = 0; x < Objectives.Length; x++)
        {
            Objectives[x].SetActive(true);
        }
        
    }

    public void HideObjectives()
    {
        if (Objectives_Displayed == true)
        { 
            Objective_Panel.GetComponent<Image>().color = new Color(Objective_Panel.color.r, Objective_Panel.color.g, Objective_Panel.color.b, TransparanetOpacity);
            for (int x = 0; x < Objectives.Length; x++)
            {
                Objectives[x].SetActive(false);
            }
            
        }
        Objectives_Displayed = false;
        
    }

    public void SwitchShowHide()
    {
        State = !State;
        Objective_Panel.gameObject.SetActive(State);
    }

}
