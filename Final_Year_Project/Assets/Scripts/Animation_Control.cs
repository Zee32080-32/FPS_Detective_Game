using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Control : MonoBehaviour
{
    private bool PlayerInZone;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && PlayerInZone == true)
        {
            animator.SetBool("IsTalking", true);
            animator.Play("Talking");
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("IsStanding", true);
            PlayerInZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerInZone = false;
        animator.SetBool("IsTalking", false) ;
        animator.Play("Idle");
    }
}
