using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Remove_Door_Block : MonoBehaviour
{
    [SerializeField]
    Objective_Completed[] Objective_Completed;
    [SerializeField]
    GameObject Destroy_Object;
    [SerializeField]
    GameObject Activate_GameObject;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        for (int x = 0; x <= Objective_Completed.Length-1; x++)
        {
            if (Objective_Completed[x].Is_Objective_Completed == true)
            {
                Debug.Log("OBJ COMP!");
                Activate_GameObject.SetActive(true);
                Destroy(this.Destroy_Object);
            }
        }

    }
}
