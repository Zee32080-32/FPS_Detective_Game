using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Random_Patrol : MonoBehaviour
{

    private Vector3 CurrentTarget;
    public Transform[] Waypoints;
    public NavMeshAgent TheAgent;
    private int waypointIndex;
    public Transform LookAtPlayer;
    private Animator animator;


    private bool IncreaseDistanceIndex = true;

    private void Start()
    {
        waypointIndex = 0;
        TheAgent.destination = Waypoints[waypointIndex].position;
        animator = GetComponent<Animator>();





    }

    private void Update()
    {

        var dist = Vector3.Distance(Waypoints[waypointIndex].position, transform.position);


        if (dist < 0.5)
        {
            Debug.Log("Reached Waypoint" + waypointIndex);
            increaseIndex();
            
        }


        
    }

    void increaseIndex()
    {
        waypointIndex++;

        if (waypointIndex >= Waypoints.Length)
        {
            waypointIndex = 0;

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

        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            TheAgent.isStopped = false;
            increaseIndex();
            animator.SetBool("IsStanding", false);
        }
    }
}
    
