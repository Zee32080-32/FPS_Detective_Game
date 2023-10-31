using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class Display_Note_Pad_Evidence : MonoBehaviour
{

    public static int EvidenceCollectedCounter;
    private bool DoOnce;
    Inspect Inspect;
    //public TMP_Text evidence_Panel;
    [SerializeField]
    private GameObject Panel;
    [SerializeField]
    private GameObject HiddenPanel;
    public bool EvidenceCollected;
    int counter;

    // Start is called before the first frame update
    void Start()
    {
        //evidence_Panel = GetComponent<TMP_Text>();
        //evidence_Panel.GetComponent<TMP_Text>().enabled = false;
        Panel.SetActive(false);
        HiddenPanel.SetActive(true);
        Inspect = FindObjectOfType<Inspect>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void Display()
    {
        EvidenceCollectedCounter += 1;

        Debug.Log("EvidenceCollectedCounter "+ EvidenceCollectedCounter);
        //StartCoroutine(Del());
        EvidenceCollected = true;
        Panel.SetActive(true);
        HiddenPanel.SetActive(false);
        Debug.Log("Method is being called");

    }

    IEnumerator Del()
    {
        yield return new WaitForEndOfFrame();
    }


}
