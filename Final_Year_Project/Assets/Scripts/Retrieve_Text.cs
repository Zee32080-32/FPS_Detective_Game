using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Retrieve_Text : MonoBehaviour
{

    public static string NameStr;
    public TMP_Text Player_Name_TextBox;

    // Start is called before the first frame update
    void Start()
    {
        Player_Name_TextBox = GetComponent<TMP_Text>();
        Player_Name_TextBox.text = NameStr;

    }

    // Update is called once per frame
    void Update()
    {
        if (NameStr == null || NameStr == "")
        {
            NameStr = "Player did not give a name :(";
        }

    }
}
