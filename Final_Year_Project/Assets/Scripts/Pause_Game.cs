using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Game : MonoBehaviour
{
    [SerializeField]
    bool isPaused = false;

    public KeyCode KeyPress = KeyCode.Alpha1;
    // Start is called before the first frame update
    public void Update()
    {
        if(Input.GetKeyDown(KeyPress))
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else 
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
    }

}
