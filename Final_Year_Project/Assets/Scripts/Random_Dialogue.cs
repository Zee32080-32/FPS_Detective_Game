using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Random_Dialogue : MonoBehaviour
{
    public GameObject TextBox;
    public TMP_Text TheText;
    public TextAsset textFile; //text asset is a block of a text
    public string[] textLines;

    public int CurrentLine; //know where it is reading current line
    public int EndLine; //know when it has stopped reading
    public System.Random Rand;
    public string pickLine;



    // Start is called before the first frame update
    void Start()
    {

        if (textFile != null) //makes sure textfile is not empty
        {
            textLines = (textFile.text.Split('\n')); //split the text into seperate pieces

            Rand = new System.Random(); //creates a random generator
            CurrentLine = Rand.Next(textLines.Length); //randomises the starting point
            pickLine = textLines[CurrentLine]; // puts that line in the array
            
        }

        if (EndLine == 0)
        {
            EndLine = textLines.Length - 1; // goes to the last line and stops

        }


    }

    void Update()
    {
        TheText.text = textLines[CurrentLine]; //uses CurrentLine to display textS
            /*
            CurrentLine = Rand.Next(textLines.Length);
            pickLine = textLines[CurrentLine];
            TheText.text = textLines[CurrentLine]; //uses CurrentLine to display textS
            Debug.Log("Change Text Line" + CurrentLine);
            */
        
        
        if(CurrentLine > EndLine)
        {
            DisableTextBox();
        }
        

    }

    public void EnableTextBox()
    {
        TextBox.SetActive(true);
    }

    public void DisableTextBox()
    {
        TextBox.SetActive(false);
        Debug.Log("Disable convo");
    }




}
