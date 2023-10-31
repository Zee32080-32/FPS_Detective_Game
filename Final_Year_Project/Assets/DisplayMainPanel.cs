using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMainPanel : MonoBehaviour
{
    [SerializeField]
    bool inZone;
    [SerializeField]
    GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inZone == true && Input.GetKeyDown(KeyCode.F))
        {
            Panel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inZone = true;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inZone = false;

        }
    }
}
