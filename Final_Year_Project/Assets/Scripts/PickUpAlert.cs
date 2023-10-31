using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpAlert : MonoBehaviour
{
    public GameObject PickUpMesage;
   // public Button[] Buttons;
    public GameObject Display_Evidence;
    private int counter = 0;
    private bool NearEvidence;
    private bool EvidenceCollected;
    Collectible Collectible;
    public Text Text;

    // Start is called before the first frame update
    void Start()
    {
        EvidenceCollected = false;
        Collectible = FindObjectOfType<Collectible>();
        PickUpMesage.GetComponent<Text>().enabled = false;
    }


    void Update()
    {
        if (Collectible.DisplayPickUpAlert == true)
        {
            
            Display_Message();
        }
    }
    public void Display_Message()
    {
        PickUpMesage.GetComponent<Text>().enabled = true;
        Display_Evidence.SetActive(true);
        EvidenceCollected = true;
        Collectible.DisplayPickUpAlert = false;
        Invoke("Hide", 3f);
        Debug.Log("Display picked up message");
       
    }
    private void Hide()
    {
       
        PickUpMesage.GetComponent<Text>().enabled = false;
        Debug.Log("Destroyed picked up message");

    }

    public void DisableButtons(Button[] array)
    {
        for (int x = 0; x < array.Length; x++)
        {
            array[x].enabled = false;
           
        }
    }

    public void ActivateButtons(Button[] array)
    {
        for (int x = 0; x < array.Length; x++)
        {
            array[x].enabled = true;
            
        }
    }
}
