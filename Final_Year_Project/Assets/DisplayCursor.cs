using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCursor : MonoBehaviour
{
    [SerializeField]
    GameObject panel;
    // Start is called before the first frame update
    void Start()
    {

      
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.activeSelf == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
