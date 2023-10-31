using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPrefsNotes : MonoBehaviour
{


    public TMP_InputField LeftPage;
    public TMP_InputField RightPage;

    public string LeftPage_Text;
    public string RightPage_Text;
    // Start is called before the first frame update
    void Start()
    {
        LeftPage.text = PlayerPrefs.GetString("LeftPage_Text");
        RightPage.text = PlayerPrefs.GetString("RightPage_Text");


    }

    // Update is called once per frame
    void Update()
    {
       
        PlayerPrefs.SetString("LeftPage_Text", LeftPage.text);
        PlayerPrefs.SetString("RightPage_Text", RightPage.text);


    }


}
