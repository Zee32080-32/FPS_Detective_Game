using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_GameObject : MonoBehaviour
{

    public GameObject Light;
    private bool LightIsOn;
    // Start is called before the first frame update
    void Start()
    {
        Light.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void TurnLightOn()
    {

        Light.SetActive(true);
    }

    public void TurnLightOff()
    {
        Light.SetActive(false);
    }
}
