using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dispay_Email : MonoBehaviour
{
    [SerializeField]
    GameObject panel;
    [SerializeField]
    bool inZone;

    [SerializeField]
    GameObject Objective;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && inZone == true)
        {
            panel.SetActive(true);
            Objective.GetComponent<TMP_Text>().fontStyle = FontStyles.Strikethrough;

        }
        if (inZone == false)
        {
            panel.SetActive(false);
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
