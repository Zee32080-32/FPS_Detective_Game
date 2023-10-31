using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Second_Part_Of_Text : MonoBehaviour
{
    [SerializeField]
    GameObject Objective_Completed;
    [SerializeField]
    GameObject Deactivate_Object;
    [SerializeField]
    GameObject Activate_Object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Objective_Completed.activeSelf == true)
        {
            Deactivate_Object.SetActive(false);
            Activate_Object.SetActive(true);
        }
    }
}
