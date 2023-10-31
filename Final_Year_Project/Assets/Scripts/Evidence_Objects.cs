using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evidence_Objects : MonoBehaviour
{
    /*
    public GameObject Victim_Details_1;
    public GameObject hVictim_Details_1;
    public static int victim_Details_1;

    public GameObject Victim_Details_2;
    public GameObject hVictim_Details_2;
    public static int victim_Details_2;

    public GameObject Victim_Details_3;
    public GameObject hVictim_Details_3;
    public static int victim_Details_3;

    public GameObject Victim_Details_4;
    public GameObject hVictim_Details_4;
    public static int victim_Details_4;

    public GameObject Boot_Details;
    public GameObject hBoot_Details;
    public static int boot_Details;

    public GameObject Hole_Details;
    public GameObject hHole_Details;
    public static int hole_Details;

    public GameObject Bin_Details;
    public GameObject hBin_Details;
    public static int bin_Details;

    public GameObject Inside_Of_Car_Details_1;
    public GameObject hInside_Of_Car_Details_1;
    public static int inside_Of_Car_Details_1;

    public GameObject Inside_Of_Car_Details_2;
    public GameObject hInside_Of_Car_Details_2;
    public static int inside_Of_Car_Details_2;

    public GameObject Inside_Of_Car_Details_3;
    public GameObject hInside_Of_Car_Details_3;
    public static int inside_Of_Car_Details_3;

    public GameObject Inside_Of_Car_Details_4;
    public GameObject hInside_Of_Car_Details_4;
    public static int inside_Of_Car_Details_4;

    public GameObject Inside_Of_Car_Details_5;
    public GameObject hInside_Of_Car_Details_5;
    public static int inside_Of_Car_Details_5;

    // Start is called before the first frame update
    void Start()
    {
        victim_Details_1 = PlayerPrefs.GetInt("victim_Details_1", 1);
        victim_Details_2 = PlayerPrefs.GetInt("victim_Details_2", 1);
        victim_Details_3 = PlayerPrefs.GetInt("victim_Details_3", 1);
        victim_Details_4 = PlayerPrefs.GetInt("victim_Details_4", 1);

        boot_Details = PlayerPrefs.GetInt("boot_Details", 1);

        hole_Details = PlayerPrefs.GetInt("hole_Details", 1);
        bin_Details = PlayerPrefs.GetInt("bin_Details", 1);

        inside_Of_Car_Details_1 = PlayerPrefs.GetInt("inside_Of_Car_Details_1", 1);
        inside_Of_Car_Details_2 = PlayerPrefs.GetInt("inside_Of_Car_Details_2", 1);
        inside_Of_Car_Details_3 = PlayerPrefs.GetInt("inside_Of_Car_Details_3", 1);
        inside_Of_Car_Details_4 = PlayerPrefs.GetInt("inside_Of_Car_Details_4", 1);
        inside_Of_Car_Details_5 = PlayerPrefs.GetInt("inside_Of_Car_Details_5", 1);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hole_Details);
        if (victim_Details_1 == 1)
        {
            hVictim_Details_1.SetActive(true);
            Victim_Details_1.SetActive(false);
        }
        if (victim_Details_1 == 2)
        {
            hVictim_Details_1.SetActive(false);
            Victim_Details_1.SetActive(true);
        }

        if (victim_Details_2 == 1)
        {
            hVictim_Details_2.SetActive(true);
            Victim_Details_2.SetActive(false);
        }
        if (victim_Details_2 == 2)
        {
            hVictim_Details_2.SetActive(false);
            Victim_Details_2.SetActive(true);
        }

        if (victim_Details_3 == 1)
        {
            hVictim_Details_3.SetActive(true);
            Victim_Details_3.SetActive(false);
        }
        if (victim_Details_3 == 2)
        {
            hVictim_Details_3.SetActive(false);
            Victim_Details_3.SetActive(true);
        }

        if (victim_Details_4 == 1)
        {
            hVictim_Details_4.SetActive(true);
            Victim_Details_4.SetActive(false);
        }
        if (victim_Details_4 == 2)
        {
            hVictim_Details_4.SetActive(false);
            Victim_Details_4.SetActive(true);
        }

        
        if (boot_Details == 1)
        {
            hBoot_Details.SetActive(true);
            Boot_Details.SetActive(false);
        }
        if (boot_Details == 2)
        {
            hBoot_Details.SetActive(false);
            Boot_Details.SetActive(true);
        }


        if (hole_Details == 1)
        {
            hHole_Details.SetActive(true);
            Hole_Details.SetActive(false);
        }
        if (hole_Details == 2)
        {
            hHole_Details.SetActive(false);
            Hole_Details.SetActive(true);
        }


        if (bin_Details == 1)
        {
            hBin_Details.SetActive(true);
            Bin_Details.SetActive(false);
        }
        if (bin_Details == 2)
        {
            hBin_Details.SetActive(false);
            Bin_Details.SetActive(true);
        }


        if (inside_Of_Car_Details_1 == 1)
        {
            hInside_Of_Car_Details_1.SetActive(true);
            Inside_Of_Car_Details_1.SetActive(false);
        }
        if (inside_Of_Car_Details_1 == 2)
        {
            hInside_Of_Car_Details_1.SetActive(false);
            Inside_Of_Car_Details_1.SetActive(true);
        }

        if (inside_Of_Car_Details_2 == 1)
        {
            hInside_Of_Car_Details_2.SetActive(true);
            Inside_Of_Car_Details_2.SetActive(false);
        }
        if (inside_Of_Car_Details_2 == 2)
        {
            hInside_Of_Car_Details_2.SetActive(false);
            Inside_Of_Car_Details_2.SetActive(true);
        }

        if (inside_Of_Car_Details_3 == 1)
        {
            hInside_Of_Car_Details_3.SetActive(true);
            Inside_Of_Car_Details_3.SetActive(false);
        }
        if (inside_Of_Car_Details_3 == 2)
        {
            hInside_Of_Car_Details_3.SetActive(false);
            Inside_Of_Car_Details_3.SetActive(true);
        }

        if (inside_Of_Car_Details_4 == 1)
        {
            hInside_Of_Car_Details_4.SetActive(true);
            Inside_Of_Car_Details_4.SetActive(false);
        }
        if (inside_Of_Car_Details_4 == 2)
        {
            hInside_Of_Car_Details_4.SetActive(false);
            Inside_Of_Car_Details_4.SetActive(true);
        }

        if (inside_Of_Car_Details_5 == 1)
        {
            hInside_Of_Car_Details_5.SetActive(true);
            Inside_Of_Car_Details_5.SetActive(false);
        }
        if (inside_Of_Car_Details_5 == 2)
        {
            hInside_Of_Car_Details_5.SetActive(false);
            Inside_Of_Car_Details_5.SetActive(true);
        }
    }
    */
}
