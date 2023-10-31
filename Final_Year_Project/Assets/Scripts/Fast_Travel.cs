using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Fast_Travel : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    public void LoadScene0()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadScene4()
    {
        SceneManager.LoadScene(4);
    }



    void Resume()
    {
        PauseMenuUI.SetActive(false);
        //Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        //Time.timeScale = 0f;
        GameIsPaused = true;
    }

}
