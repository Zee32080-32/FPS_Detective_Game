using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Time_Manager_Continous : MonoBehaviour
{
    public static Time_Manager_Continous instance;

    [SerializeField]
    private static TimeSpan TimePlaying;
    private bool TimerGoing;
    [SerializeField]
    private float elapsedTime;
    /*
    [SerializeField]
    Send_To_Google_Form Send_To_Google_Form;
    */



    private void Awake()
    {
        

        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //TimerCounter.text = "Time: 00:00:00";
        TimerGoing = false;
        Time_Manager_Continous.instance.BeginTimer();
    }
    /*
    public void SendTimeCont()
    {
        Send_To_Google_Form.SendTime_Total(elapsedTime.ToString());
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

            string TimePlayingStr = "Timer: " + TimePlaying.ToString("hh':'mm':'ss");
           


            yield return null;
        }
    }

}
