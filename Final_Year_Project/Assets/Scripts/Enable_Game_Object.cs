using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enable_Game_Object : MonoBehaviour
{
    [SerializeField]
    Door_animation Door_animation;
    [SerializeField]
    private GameObject Object;
    // Start is called before the first frame update
    void Start()
    {
        Object.SetActive(false);
        Door_animation = FindObjectOfType<Door_animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Door_animation.Door_Is_Open == true)
        {
            Object.SetActive(true);

        }    
    }
}
