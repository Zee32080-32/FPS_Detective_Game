using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispaly_Autopsy_Report : MonoBehaviour
{
    private Activate_Text Activate_Text;
    private GameObject AutopsyReport;
    // Start is called before the first frame update
    void Start()
    {
        AutopsyReport.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Activate_Text.DialogueFinished == true)
        {
            AutopsyReport.SetActive(true);
        }
    }
}
