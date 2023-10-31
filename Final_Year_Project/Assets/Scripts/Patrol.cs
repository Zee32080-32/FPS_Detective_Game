using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    private Animator animator;

    private Vector3 CurrentTarget;
    public Transform[] Waypoints;
    public NavMeshAgent TheAgent;
    private int waypointIndex;
    public Transform LookAtPlayer;

    private bool IncreaseDistanceIndex = true;
    
    private void Start()
    {
        waypointIndex = 0;
        TheAgent.destination = Waypoints[waypointIndex].position;

        animator = GetComponent<Animator>();
        //Debug.Log(animator);

       
      
    }

    private void Update()
    {

        var dist = Vector3.Distance(Waypoints[waypointIndex].position, transform.position);
       

        if (dist < 5)
        {
            increaseIndex();
            //Debug.Log("distance is less than 5");
            //Debug.Log(waypointIndex);
        }


        //var NPCToPlayerDist = Vector3.Distance(transform.position, LookAtPlayer.transform.position);
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
            animator.SetBool("IsStanding", false);
        }
    }
   
}





