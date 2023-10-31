using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Hide_And_Display_UI : MonoBehaviour
{
    private Dialogue Dialogue;
    public GameObject Panel;
    public GameObject ClipBoardPanel;
    // Start is called before the first frame update

  

    public void OpenPanel()
    {
        if (!Panel)
        {
            bool isSetActive = Panel.activeSelf;
            Panel.SetActive(true);

        }    
    }

    public void OpenClipBoard()
    {
        Dialogue = FindObjectOfType<Dialogue>();
        if (!Panel && Dialogue.ConversationDone == true)
        {
        bool isSetActive = ClipBoardPanel.activeSelf;
        ClipBoardPanel.SetActive(true);

        }
    }


}
