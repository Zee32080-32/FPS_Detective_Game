﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Camera : MonoBehaviour
{
    [SerializeField]
    private GameObject Second_Camera;

    [SerializeField]
    private GameObject Main_Camera;

    [SerializeField]
    private GameObject Main_Panel;
    [SerializeField]
    private bool inZone;

    private float speed = 20f;
    [SerializeField]
    private GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        Text.SetActive(false);

        Second_Camera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inZone == true && Input.GetKeyDown(KeyCode.F))
        {
            Main_Panel.SetActive(false);
            Second_Camera.SetActive(true);
            Main_Camera.SetActive(false);
            Text.SetActive(true);

        }

        if (Input.GetButtonDown("1Key"))
        {
            inZone = false;
            Main_Camera.SetActive(true);
            Second_Camera.SetActive(false);
            Text.SetActive(false);
            Main_Panel.SetActive(true);


        }
    }

    private void OnTriggerStay(Collider other)
    {
        inZone = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inZone = false;
    }
}
