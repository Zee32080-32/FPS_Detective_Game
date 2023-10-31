using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Display_Map_Button : MonoBehaviour
{
    public TMP_Text Text;
    public float BlinkFadeInTime = 0.5f;
    public float BlinkStayInTime = 0.8f;
    public float BlinkFadeOutTime = 0.7f;
    public bool UI_Flash;
    [SerializeField]
    private float TimeChecker = 0f;
    private Color Colour;
    public KeyCode KeyPress = KeyCode.Alpha1;

    // Start is called before the first frame update
    void Start()
    {
        UI_Flash = true;
        //Text = GetComponent<Text>();
        Colour = Text.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (UI_Flash == true)
        {
            MakeIconFlash();
        }
        
        if (Input.GetKeyDown(KeyPress))
        {
            KeepIconOpacity();
        }
    }

    void MakeIconFlash()
    {
        TimeChecker += Time.deltaTime;
        if (TimeChecker < BlinkFadeInTime)
        {
            Text.color = new Color(Colour.r, Colour.g, Colour.b, TimeChecker / BlinkFadeInTime);
        }
        else if (TimeChecker < BlinkFadeInTime + BlinkStayInTime)
        {
            Text.color = new Color(Colour.r, Colour.g, Colour.b, 1);
        }
        else if (TimeChecker < BlinkFadeInTime + BlinkStayInTime + BlinkFadeOutTime)
        {
            Text.color = new Color(Colour.r, Colour.g, Colour.b, 1 - (TimeChecker - (BlinkFadeInTime + BlinkStayInTime) / BlinkFadeOutTime));
        }
        else
        {
            TimeChecker = 0;
        }
    }

    public void KeepIconOpacity()
    {
        UI_Flash = false;
        Text.color = new Color(Colour.r, Colour.g, Colour.b, 1); 

    }
}
