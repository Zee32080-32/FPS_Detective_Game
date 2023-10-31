using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Activate_Pathfinder : MonoBehaviour
{
    [SerializeField]
    private Dialogue Dialogue;

    public Transform[] Waypoints;
    public NavMeshAgent TheAgent;
    private int waypointIndex;
    public Transform LookAtPlayer;
    private Animator animator;
    private bool ArrivedAtDestination;
    [SerializeField]
    private Activate_Text Activate_Text;
    [SerializeField]
    private GameObject TextPanel;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Dialogue = FindObjectOfType <Dialogue>();
        Activate_Text.FindObjectOfType<Activate_Text>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Activate_Text.GetComponent<Activate_Text>().DialogueFinished == true)
        {
            if (TextPanel.activeSelf == false)
                { 
                    StartCoroutine(DelayDestination());

                }
          

        }
    }



    private IEnumerator DelayDestination()
    {
        yield return new WaitForSeconds(2);
        MoveToFirstPosition();
      
    }

    void LookAtPlayerMethod()
    {
        Vector3 direction = LookAtPlayer.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }

    private void MoveToFirstPosition()
    {
        var dist = Vector3.Distance(Waypoints[waypointIndex].position, transform.position);
        if (ArrivedAtDestination == false)
        {
            waypointIndex = 0;
          
            animator.SetBool("IsWalking", true);
            animator.Play("Walking");
            TheAgent.destination = Waypoints[waypointIndex].position;
        }


     

        if (dist <= 0.7 && ArrivedAtDestination == false)
        {
            ArrivedAtDestination = true;
            TheAgent.isStopped = true;
            this.gameObject.GetComponent<NavMeshAgent>().enabled = false;
            animator.SetBool("IsWalking", false);
            animator.Play("idle");
            Debug.Log("ARRIVED");
        }

    }
}
