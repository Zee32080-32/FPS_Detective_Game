using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Send_To_Google_Form : MonoBehaviour
{
    Retrieve_Text Retrieve_Text;
    private string PlayerName;
    [SerializeField]
    Timer_Manager Timer_Manager;

    [SerializeField]
    string BASE_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSczhTtOCw6iUMpYpfdMwwlHh2KGOQkVsJUEwZvAyZ5WwemhIw/formResponse";
    private string Player_Name;
    private string Object_Name;
    public bool Collected;
    /*
    [SerializeField]
    string TimeInPoliceRoom_FirstScene;

    [SerializeField]
    string TimeInCrimeScene_SecondScene;

    [SerializeField]
    string TimeInPoliceStation_FinalScene;

    [SerializeField]
    string TotalTimePlayed;
    */
    [SerializeField]
    WWWForm form;

    string timeInPoliceRoom_FirstScene;
    string timeInCrimeScene_SecondScene;
    string timeInPoliceStation_FinalScene;
    string totalTimePlayed;


    private void Start()
    {
        form = new WWWForm();
        Timer_Manager = FindObjectOfType<Timer_Manager>();
        PlayerName = Retrieve_Text.NameStr;
       
    }


    public void Send(string SendPlayerName, string SendObject_Name)
    {
        if (Collected == false)
        { 
            StartCoroutine(Post(SendPlayerName, SendObject_Name));
            Debug.Log("SENDING TO GOOGLE FORM");
        }
        
    }

    public IEnumerator Post(string Player_Name, string Object_Name)
    {
        Collected = true;
        form.AddField("entry.1507217880", Player_Name);
        form.AddField("entry.917322820", Object_Name);
        
        byte[] rawData = form.data;
        WWW WWW = new WWW(BASE_URL, rawData);
        yield return WWW;
        
    }

    public void SendTime_1(string first_Level)
    {
        StartCoroutine(PostTime_1(first_Level));
        Debug.Log("SENDING TIME 1 TO GOOGLE FORM");
    }

    public void SendTime_2(string second_level)
    {
        StartCoroutine(PostTime_2(second_level));
        Debug.Log("SENDING TIME 2 TO GOOGLE FORM");
    }

    public void SendTime_3(string third_level)
    {
        StartCoroutine(PostTime_3(third_level));
        Debug.Log("SENDING TIME 3 TO GOOGLE FORM");
    }

    public void SendTime_Total(string Total_Time)
    {
        StartCoroutine(PostTime_Total(Total_Time));
       
    }


    public IEnumerator PostTime_1(string Time)
    {
        
       
        form.AddField("entry.290094488", Timer_Manager.elapsedTime.ToString("hh':'mm':'ss"));
        byte[] rawData = form.data;
        WWW WWW = new WWW(BASE_URL, rawData);
        yield return WWW;

    }

    public IEnumerator PostTime_2(string Time)
    {

       

        form.AddField("entry.1018368048", Time);
        byte[] rawData = form.data;
        WWW WWW = new WWW(BASE_URL, rawData);
        yield return WWW;

    }

    public IEnumerator PostTime_3(string Time)
    {
      
        form.AddField("entry.1239819477", Time);
        byte[] rawData = form.data;
        WWW WWW = new WWW(BASE_URL, rawData);
        yield return WWW;

    }

    public IEnumerator PostTime_Total(string Time)
    {
     
        form.AddField("entry.1863619507", Time);
        byte[] rawData = form.data;
        WWW WWW = new WWW(BASE_URL, rawData);
        yield return WWW;

    }

}
