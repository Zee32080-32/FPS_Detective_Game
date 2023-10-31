using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display_Weblink_With_Key_Press : MonoBehaviour
{
    public bool WebLinkDisplayed;
    [SerializeField]
    bool InZone;
    [SerializeField]
    string Weblink;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && WebLinkDisplayed == false && InZone == true)
        {
            Open_Links.OpenUrl(Weblink);
            WebLinkDisplayed = true;
            Debug.Log("link displayed");

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        InZone = true;
    }

    private void OnTriggerExit(Collider other)
    {
        InZone = false;
    }
}
