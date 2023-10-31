using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Weblink : MonoBehaviour
{
    [SerializeField]
    Dialogue Dialogue;
    [SerializeField]
    bool WebLinkDisplayed;
    [SerializeField]
    string[] Weblink;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Dialogue.Activate_WebLink == true && WebLinkDisplayed == false)
        {
            for (int x = 0; x < Weblink.Length; x++)
            { 
                Open_Links.OpenUrl(Weblink[x]);
                WebLinkDisplayed = true;
            }
 

        }

    }
}
