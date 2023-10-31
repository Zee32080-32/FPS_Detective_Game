using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display_Object_Description : MonoBehaviour
{
    [SerializeField]
    GameObject Object_1;
    [SerializeField]
    GameObject Object_2;
    [SerializeField]
    bool InZone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Object_1.activeSelf == true && InZone == true)
        {
            Object_2.SetActive(true);
        }
        else 
        {
            Object_2.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
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
}
