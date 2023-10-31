using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHideShow : MonoBehaviour
{
    [SerializeField]
    bool isLocked;


    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        isLocked = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3)) && isLocked == false)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            isLocked = true;
        }
        else if ((Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Alpha2)|| Input.GetKeyDown(KeyCode.Alpha3)) && isLocked == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            isLocked = false;
        }
    }
}
