using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using UnityStandardAssets.Characters.FirstPerson;

public class Create_Notes : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField Notes;
    [SerializeField]
    private GameObject FPS_Controller;



    // Start is called before the first frame update
    void Start()
    {
        Directory.CreateDirectory(Application.streamingAssetsPath + "/Notes/");
    }

    // Update is called once per frame
    void Update()
    {



    }

    public void CreateFile()
    {
        
        if (Notes.text == "")
        {
            return;
        }
        string txtDocumentName = Application.streamingAssetsPath + "/Notes/" + "Notes" + ".txt";

        if (!File.Exists(txtDocumentName))
        {
            Debug.Log("File Exists");
        }

        File.AppendAllText(txtDocumentName, Notes.text + "\n");
    }

}
