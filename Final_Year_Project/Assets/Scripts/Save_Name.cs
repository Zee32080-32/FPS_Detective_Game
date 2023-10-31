using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Save_Name : MonoBehaviour
{
    static public string Name;
    public GameObject InputField;
    //public GameObject Display;
    TextMeshPro TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro TextmeshPro = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StoreName()
    {
        name = InputField.GetComponent<TextMeshPro>().text;
        //Display.GetComponent<TextMeshPro>().text;
    }
}
