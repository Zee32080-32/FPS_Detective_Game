using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer_Manager : MonoBehaviour
{
    public static Timer_Manager instance;
    public TMP_Text TimerCounter;
    [SerializeField]
    private static TimeSpan TimePlaying;
    private bool TimerGoing;
    public float elapsedTime;
    //[SerializeField]
    //Send_To_Google_Form Send_To_Google_Form;

    string x = "HELlo;";


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
        //TimerCounter.text = "Time: 00:00:00";
        TimerGoing = false;
        Timer_Manager.instance.BeginTimer();
    }
    /*
    public void SendTime_1()
    {
        Send_To_Google_Form.SendTime_1(elapsedTime.ToString());
    }
    */

    //public void SendTime_2()
    //{
       // Send_To_Google_Form.SendTime_2(x.ToString());
    //}
//
    /*
    public void SendTime_3()
    {
        Send_To_Google_Form.SendTime_3(elapsedTime.ToString());
    }
    */



    public void BeginTimer()
    {
        TimerGoing = true;
        //elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    
    }

    public void EndTimer()
    {
        TimerGoing = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (TimerGoing)
        {
            elapsedTime += Time.deltaTime;
            TimePlaying = TimeSpan.FromSeconds(elapsedTime);

            string  TimePlayingStr = "Timer: " + TimePlaying.ToString("hh':'mm':'ss");
            TimerCounter.text = TimePlayingStr;
          

            yield return null;
        }
    }


}
