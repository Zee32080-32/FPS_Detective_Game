using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Animation : MonoBehaviour
{
    private bool InZone;
    public Animator Seat;
    public bool SeatForward;

    private void Start()
    {

        SeatForward = false;
    }

    private void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.F) && InZone)
        {

            Seat.GetComponent<Animator>().Play("Idle");
            StartCoroutine(Delay());

        }
        */


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            InZone = true;

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            InZone = false;

        }

    }

    public void Move_Car_Door()
    {
        Seat.GetComponent<Animator>().SetBool("Move_Seat", true);

    }

    public void Move_Car_Door_Back()
    {
        Seat.GetComponent<Animator>().SetBool("Move_Seat", false);
    }


    
    IEnumerator Delay()
    {

        yield return new WaitForSeconds(1);
    }

}
