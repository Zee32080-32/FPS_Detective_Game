using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Display_Start_Button : MonoBehaviour
{
    private string text;
    [SerializeField]
    private GameObject Start_Button;
    [SerializeField]
    private GameObject Start_Button_Text;
    [SerializeField]
    private TMP_InputField InputField;

    // Start is called before the first frame update
    void Start()
    {
        string text = InputField.GetComponent<TMP_InputField>().text;
        Start_Button.SetActive(false);
        Start_Button_Text.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DisplayStartButton()
    {
        if (text == " " || text == null)
        {
            Start_Button.SetActive(false);
            Start_Button_Text.SetActive(false);
        }

    }
}
