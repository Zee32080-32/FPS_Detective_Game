using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InspectController : MonoBehaviour
{
    [SerializeField]
    private GameObject ObjNameBG;

    [SerializeField]
    private GameObject ObjDescriptionBG;

    [SerializeField]
    private TMP_Text ObjNameUI;

    [SerializeField]
    private TMP_Text ObjDescriptionUI;

    [SerializeField]
    private float OnScreenTimer;

    [SerializeField]
    private bool StartTimer;

    [SerializeField]
    private float Timer;


    // Start is called before the first frame update
    void Start()
    {
        ObjNameBG.SetActive(false);
        ObjDescriptionBG.SetActive(false);
    }

    private void Update()
    {
        if (StartTimer)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                Timer = 0;
                HideObjName();
                HideObjDescription();
                StartTimer = false;
            }
        }
    }

    public void ShowObjName(string ObjName)
    {
        Timer = OnScreenTimer;
        StartTimer = true;

        ObjNameBG.SetActive(true);
        ObjNameUI.text = ObjName;
    }

    public void HideObjName()
    {
        ObjNameBG.SetActive(false);
        ObjNameUI.text = "";
    }

    public void ShowObjDescription(string ObjDescription)
    {
        Timer = OnScreenTimer;
        StartTimer = true;
        ObjDescriptionBG.SetActive(true);
        ObjDescriptionUI.text = ObjDescription;
    }
    public void HideObjDescription()
    {
        ObjDescriptionBG.SetActive(false);
        ObjDescriptionUI.text = "";
    }

}
