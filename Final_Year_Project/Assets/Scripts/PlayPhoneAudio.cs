using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayPhoneAudio : MonoBehaviour
{
    private bool InZone;
    private bool KeyPressed;
    public GameObject MapButton;
    public GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayPhoneRing());
    }

    // Update is called once per frame
    void Update()
    {
        if (InZone == true)
        {
            DisplayGUI();

        }
    }

    private IEnumerator DelayPhoneRing()
    {
        while (KeyPressed == false)
        {
            yield return new WaitForSeconds(3f);
            FindObjectOfType<Audio_Manager>().Play("PhoneRing");

            if (KeyPressed == true)
            {
                FindObjectOfType<Audio_Manager>().Stop("PhoneRing");
                Text.SetActive(true);
            }
           
        }

    }

    private IEnumerator DelayUI()
    {
        yield return new WaitForSeconds(3f);
        MapButton.SetActive(true);
    }

    private void DisplayGUI()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            KeyPressed = true;
            StartCoroutine(DelayUI());
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            InZone = true;
        }
    }
}
