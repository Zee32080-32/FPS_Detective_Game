using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Alert : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<Audio_Manager>().Play("Alert");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<Audio_Manager>().Stop("Alert");
        }
    }

}
