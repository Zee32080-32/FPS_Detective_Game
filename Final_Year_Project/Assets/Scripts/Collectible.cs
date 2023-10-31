using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityStandardAssets.Characters.FirstPerson;

public class Collectible : MonoBehaviour
{
    RecordStats RecordStats;
    Inspect Inspect;
    public bool Collected = false;
    public bool DisplayPickUpAlert;
    public bool Destroy;
    InspectController InspectController;
    Retrieve_Text Retrieve_Text;
    private string txtDocumentName;
    // Start is called before the first frame update
    void Start()
    {
        Retrieve_Text = FindObjectOfType<Retrieve_Text>();
        InspectController = FindObjectOfType<InspectController>();
        RecordStats = FindObjectOfType<RecordStats>();
        Inspect = FindObjectOfType<Inspect>();

        Directory.CreateDirectory(Application.streamingAssetsPath + "/Collectible/");

        string txtDocumentName = Application.streamingAssetsPath + "/Collectible/" + "Collectible" + ".txt";

    }

    private void Update()
    {

    }

    public void SaveCollectible(string Description)
    {
        if (Collected == false)
        {
            RecordStats.AddRecord(Description, Retrieve_Text.NameStr, Application.streamingAssetsPath + "/Collectible/" + "Collectible" + ".txt");
            Collected = true;
            Debug.Log("Collected = " + Collected);


            Debug.Log("Saved Evidence");
        }

    }




}
