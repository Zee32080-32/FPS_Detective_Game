using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dont_Destroy_On_Load : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("Not destroying obj");
        DontDestroyOnLoad(this.gameObject);


    }


}
