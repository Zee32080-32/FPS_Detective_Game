using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithUI : MonoBehaviour
{
    [SerializeField]
    GameObject Panel;
    [SerializeField]
    bool PanelActive;
    public KeyCode KeyPress = KeyCode.Alpha1;

     
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyPress) && PanelActive == false)
        {
            Panel.SetActive(true);
            PanelActive = true;
        }

        else if (Input.GetKeyDown(KeyPress) && PanelActive == true)
        {
            Panel.SetActive(false);
            PanelActive = false;
        }
    }
}
