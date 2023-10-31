using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Map : MonoBehaviour
{
    public GameObject Map;
    public GameObject ClipBoard;

    public void OpenMap()
    {
        if(Map != null)
        {
            bool isActive = Map.activeSelf;
            Map.SetActive(!isActive);
        }
      
    }

    public void OpenConversationHistory()
    {
        if (ClipBoard != null)
        {
            bool isActive = ClipBoard.activeSelf;
            ClipBoard.SetActive(!isActive);
        }

    }
}
