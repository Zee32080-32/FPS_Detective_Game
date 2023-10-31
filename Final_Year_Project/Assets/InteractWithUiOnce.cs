using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithUiOnce : MonoBehaviour
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
        if (Panel.activeSelf == true)
        {
            PanelActive = true;

        }

        if (Input.GetKeyDown(KeyPress) && PanelActive == true)
        {
            Panel.SetActive(false);
            PanelActive = false;
        }
    }
}
