using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Evidence_Player_Prefs : MonoBehaviour
{
    [SerializeField]
    string tag;
    [SerializeField]
    Display_Note_Pad_Evidence Display_Note_Pad_Evidence;
    [SerializeField]
    Display_Note_Pad_Evidence Display_Note_Pad_EvidenceOBJ;
    public GameObject Evidence;
    public GameObject hEvidence;
    public int evidence;

    [SerializeField]
    bool displayEvidence;
    [SerializeField]
    bool ChangeInt;

    private void Start()
    {
        this.evidence = PlayerPrefs.GetInt(this.tag, 1);
        
    }

    private void Update()
    {
        if (Display_Note_Pad_EvidenceOBJ.GetComponent<Display_Note_Pad_Evidence>().EvidenceCollected == true)
        {
            this.evidence = 2;
            PlayerPrefs.SetInt(this.tag, evidence);

        }

        if (this.evidence == 1)
        {
            this.hEvidence.SetActive(true);
            this.Evidence.SetActive(false);
        }
        if (this.evidence == 2)
        {
            this.hEvidence.SetActive(false);
            this.Evidence.SetActive(true);
        }
    }




    /*
    public void VictimEvidence_1()
    {
        if (Display_Note_Pad_Evidence.EvidenceCollected == true)
        {
            Evidence_Objects.victim_Details_1 = 2;
            PlayerPrefs.SetInt("victim_Details_1", Evidence_Objects.victim_Details_1);
        }
       
    }

    public void VictimEvidence_2()
    {
        if (Display_Note_Pad_Evidence.EvidenceCollected == true)
        {
            Evidence_Objects.victim_Details_2 = 2;
            PlayerPrefs.SetInt("victim_Details_2", Evidence_Objects.victim_Details_2);
        }

    }

    public void VictimEvidence_3()
    {
        if (Display_Note_Pad_Evidence.EvidenceCollected == true)
        {
            Evidence_Objects.victim_Details_3 = 2;
            PlayerPrefs.SetInt("victim_Details_3", Evidence_Objects.victim_Details_3);
        }

    }

    public void VictimEvidence_4()
    {
        if (Display_Note_Pad_Evidence.EvidenceCollected == true)
        {
            Evidence_Objects.victim_Details_4 = 2;
            PlayerPrefs.SetInt("victim_Details_4", Evidence_Objects.victim_Details_4);
        }

    }

    public void Boot_Details()
    {
        if (Display_Note_Pad_Evidence.EvidenceCollected == true)
        {
            Evidence_Objects.boot_Details = 2;
            PlayerPrefs.SetInt("boot_Details", Evidence_Objects.boot_Details);
        }
           
    }

    public void Hole_Details()
    {
        if (Evidence_Objects.hole_Details == 1)
        {
            if (Display_Note_Pad_Evidence.EvidenceCollected == true)
            {
                Evidence_Objects.hole_Details = 2;
                PlayerPrefs.SetInt("hole_Details", Evidence_Objects.hole_Details);
                Debug.Log("The method has been called");
            }
        }
    }

    public void Bin_Details()
    {
        if (Display_Note_Pad_Evidence.EvidenceCollected == true)
        {
            Evidence_Objects.bin_Details = 2;
            PlayerPrefs.SetInt("bin_Details", Evidence_Objects.bin_Details);
        }

    }

    public void Inside_Of_Car_Details_1()
    {
        if (Display_Note_Pad_Evidence.EvidenceCollected == true)
        {
            Evidence_Objects.inside_Of_Car_Details_1 = 2;
            PlayerPrefs.SetInt("inside_Of_Car_Details_1", Evidence_Objects.inside_Of_Car_Details_1);
        }

    }

    public void Inside_Of_Car_Details_2()
    {
        if (Display_Note_Pad_Evidence.EvidenceCollected == true)
        { 
            Evidence_Objects.inside_Of_Car_Details_2 = 2;
            PlayerPrefs.SetInt("inside_Of_Car_Details_2", Evidence_Objects.inside_Of_Car_Details_2);
        }
          
    }

    public void Inside_Of_Car_Details_3()
    {
        if (Display_Note_Pad_Evidence.EvidenceCollected == true)
        {
            Evidence_Objects.inside_Of_Car_Details_3 = 2;
            PlayerPrefs.SetInt("inside_Of_Car_Details_3", Evidence_Objects.inside_Of_Car_Details_3);
        }

            
    }

    public void Inside_Of_Car_Details_4()
    {
        if (Display_Note_Pad_Evidence.EvidenceCollected == true)
        {
            Evidence_Objects.inside_Of_Car_Details_4 = 4;
            PlayerPrefs.SetInt("inside_Of_Car_Details_4", Evidence_Objects.inside_Of_Car_Details_4);
        }

    }

    public void Inside_Of_Car_Details_5()
    {
        if (Display_Note_Pad_Evidence.EvidenceCollected == true)
        {
            Evidence_Objects.inside_Of_Car_Details_5 = 2;
            PlayerPrefs.SetInt("inside_Of_Car_Details_5", Evidence_Objects.inside_Of_Car_Details_5);
        }

    }

    */
}
