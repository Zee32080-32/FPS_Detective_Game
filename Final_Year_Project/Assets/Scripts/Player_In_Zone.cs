using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_In_Zone : MonoBehaviour
{
    public bool InZone;
    Inspect Inspect;
    // Start is called before the first frame update
    void Start()
    {
        Inspect = FindObjectOfType<Inspect>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Inspect.In_Zone = true;
        }
   
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Inspect.In_Zone = false;
        }

    }
}
