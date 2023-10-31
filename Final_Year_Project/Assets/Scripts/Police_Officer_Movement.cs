using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Police_Officer_Movement : MonoBehaviour
{
    private Vector3 CurrentTarget;
    public Transform[] Waypoints;
    public NavMeshAgent TheAgent;
    private int waypointIndex;
    public Transform LookAtPlayer;
    private Animator animator;
    private Inspect Inspect;
    private bool MoveToPlayer;
    private bool ArrivedAtDestination;

    private bool IncreaseDistanceIndex = true;

    private void Start()
    {
        Inspect = FindObjectOfType<Inspect>();
        waypointIndex = 0;
        animator = GetComponent<Animator>();
        TheAgent.destination = Waypoints[waypointIndex].position;

    }

    private void Update()
    {

        var dist = Vector3.Distance(Waypoints[waypointIndex].position, transform.position);

        //Debug.Log(dist);
        if (dist < 2 && ArrivedAtDestination == false)
        {
            Debug.Log("Reached Waypoint " + waypointIndex);

            increaseIndex();

            Debug.Log("Moving to Waypoint " + waypointIndex);


        }
        Debug.Log("waypointindex = " + waypointIndex);
    }

    void increaseIndex()
    {
        waypointIndex++;
        if (waypointIndex == 12 && MoveToPlayer == false)
        {
            waypointIndex = 0;

        }
        else if (MoveToPlayer == true)
        {

            TheAgent.destination = LookAtPlayer.transform.position;

            if (waypointIndex >= Waypoints.Length)
            {
                ArrivedAtDestination = true;
                TheAgent.isStopped = true;
                LookAtPlayerMethod();
                animator.SetBool("IsStanding", true);
                waypointIndex = 0;
                Debug.Log("ARRIVED");
            }

        }
        TheAgent.destination = Waypoints[waypointIndex].transform.position;

    }

    void LookAtPlayerMethod()
    {
        Vector3 direction = LookAtPlayer.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TheAgent.isStopped = true;
            LookAtPlayerMethod();
            animator.SetBool("IsStanding", true);
            Debug.Log("NPC IN ZONE");
        }
        
        if (other.tag == "Final_Waypoint")
        {
            TheAgent.isStopped = true;
            LookAtPlayerMethod();
            animator.SetBool("IsStanding", true);
        }
        

    }

    void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            TheAgent.isStopped = false;
            animator.SetBool("IsStanding", false);
        }
    }




}
