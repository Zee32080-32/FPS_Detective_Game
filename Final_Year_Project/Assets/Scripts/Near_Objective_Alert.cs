using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Near_Objective_Alert : MonoBehaviour
{

    [SerializeField]
    private AudioSource AS;


    // Start is called before the first frame update
    void Start()
    {
        AudioSource AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            AS.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
