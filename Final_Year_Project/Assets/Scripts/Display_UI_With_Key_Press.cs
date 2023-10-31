using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display_UI_With_Key_Press : MonoBehaviour
{
    [SerializeField]
    bool InZone;
    [SerializeField]
    GameObject[] DisplayObject;
    [SerializeField]
    GameObject[] HideObject;
    public bool DisplayedObject;
    [SerializeField]
    GameObject Cam_1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (InZone == true && Input.GetKeyDown(KeyCode.F) && DisplayedObject == false)
        {
            DisplayedObject = true;
            if (DisplayedObject == true)
            {
                for (int x = 0; x < DisplayObject.Length; x++)
                {
                    DisplayObject[x].SetActive(true);

                }
                for (int x = 0; x < HideObject.Length; x++)
                {
                    HideObject[x].SetActive(false);

                }
            }


        }

        if (InZone == true && Input.GetButtonDown("1Key"))
        {
            DisplayedObject = false;
            if (DisplayedObject == false)
            {
                for (int x = 0; x < DisplayObject.Length; x++)
                {
                    DisplayObject[x].SetActive(false);

                }
                for (int x = 0; x < HideObject.Length; x++)
                {
                    HideObject[x].SetActive(true);

                }
            }
        }

        if (Cam_1.activeSelf == false)
        {
            InZone = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            InZone = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            InZone = false;
        }

    }
}
