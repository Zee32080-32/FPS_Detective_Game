using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Main_Menu : MonoBehaviour
{
   
    public TMP_InputField PlayerName;
    private void Start()
    {
      
    }
    public void StartGame()
    {
        Retrieve_Text.NameStr = PlayerName.text;
        if (PlayerName.text == null || PlayerName.text == "")
        {
            PlayerName.text = "Player did not enter a name :( ";
        }
        Debug.Log("Player name is " + PlayerName.text);
        SceneManager.LoadScene("Scene_1");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");

    }
}
