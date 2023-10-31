using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Text_Random : MonoBehaviour
{
    public TextAsset TheText;
    public int CurrentLine; //know where it is reading current line
    public int EndLine; //know when it has stopped reading
    public Random_Dialogue Random_Dialogue;
    //public bool destroyWhenActivated;
    public bool requiredButtonPress;
    private bool Player_In_Zone;
    public string pickLine;
    private bool DialogueFinished; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Player_In_Zone && Input.GetKeyDown(KeyCode.F))
        {

            //TextBox.ReloadScript(TheText);
            //TextBox.CurrentLine = CurrentLine;

            // TextBox.EndLine = EndLine;
            Random_Dialogue.EnableTextBox();
            Debug.Log("Enabling text box");
            DialogueFinished = true;
            
        }
      



    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player_In_Zone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Player_In_Zone = false;
            Random_Dialogue.DisableTextBox();
        }
    }

    
}
