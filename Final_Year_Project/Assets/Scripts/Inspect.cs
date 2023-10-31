using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Inspect : MonoBehaviour
{
    [SerializeField]
    private float rayLength = 5;

    [SerializeField]
    private LayerMask LayerMaskInteract;
    [SerializeField]
    private LayerMask LayerMaskInteract_2;
    [SerializeField]
    private LayerMask LayerMaskInteract_3;
    [SerializeField]
    private LayerMask LayerMaskInteract_4;
    Send_To_Google_Form Send_To_Google_Form;
    [SerializeField]
    private Image Crosshair;
    
    [SerializeField]
    PlayerPrefsNotes PlayerPrefsNotes;

    [SerializeField]
    private Sprite Talk_Icon;

    [SerializeField]
    private Sprite Default_Icon;

    [SerializeField]
    private bool isCrosshairActive;

    [SerializeField]
    GameObject Image_Of_Victim_Neck;

    public bool StartInterrogation;

    private objectController RaycastedObject;
    private Door_animation Door_animation;
    private objectController objectController;
    private Collectible Collectible;
    private Display_Note_Pad_Evidence Display_Note_Pad_Evidence;
    private Activate_GameObject Activate_GameObject;
    private Trigger_Animation Trigger_Animation;
    private Activate_Detective_Text Activate_Detective_Text;
    private Detective_Talks Detective_Talks;
    private GameObject Evidence;
    private Player_In_Zone Player_In_Zone;
    private bool CompleteOnce;
    public bool Interaction;
    public bool isCollectibleObject;
    private Activate_Text Activate_Text;
    public RaycastHit Hit;
    public bool Store_Evidence;
    private bool LightIsOn;
    [SerializeField]
    private bool isCollectible_1;
    [SerializeField]
    private bool isCollectible_2;
    [SerializeField]
    private bool isCollectible_3;
    [SerializeField]
    FileDownload FileDownload;
    public GameObject PickUpMesage;

    private float Opacity = 1f;
    bool LookAtClutch = false;
    bool LookAtGlasses = false;
    bool LookAtPen = false;
    bool LookAtLighter = false;
    public bool PlayerIsCollidingWithDoor = false;
    bool Collected = false;
    public bool In_Zone = false;
    public bool InteractInZone;
    public bool NearInteractObj;
    [SerializeField]
    private AudioSource AS;
    private bool DoorAudioOpenPlayed;
    Activate_Car_Cam Activate_Car_Cam;

    [SerializeField]
    bool SeatForward;
    [SerializeField]
    TMP_Text EvidenceCollectedCounterText;
    [SerializeField]
    Timer_Manager Timer_Manager;
    private void Start()
    {


        Timer_Manager = FindObjectOfType<Timer_Manager>();
        SeatForward = false;
        Send_To_Google_Form = FindObjectOfType<Send_To_Google_Form>();
        Activate_Car_Cam = FindObjectOfType<Activate_Car_Cam>();
        Evidence = GameObject.Find("Evidence");
        Activate_Detective_Text = FindObjectOfType<Activate_Detective_Text>(); 
        Display_Note_Pad_Evidence = FindObjectOfType<Display_Note_Pad_Evidence>();
        Activate_GameObject = FindObjectOfType<Activate_GameObject>();
        objectController = FindObjectOfType<objectController>();
        Collectible = FindObjectOfType<Collectible>();
        Trigger_Animation = FindObjectOfType<Trigger_Animation>();
        Detective_Talks = FindObjectOfType<Detective_Talks>();
        Door_animation = FindObjectOfType<Door_animation>();
        Player_In_Zone = FindObjectOfType<Player_In_Zone>();
        AudioSource AS = GetComponent<AudioSource>();

        Crosshair.GetComponent<Image>().color = new Color(Crosshair.color.r, Crosshair.color.g, Crosshair.color.b, Opacity);
    }


    private void Update()
    {

        EvidenceCollectedCounterText.text = "Evidence Collected: " + Display_Note_Pad_Evidence.EvidenceCollectedCounter + "/10";
        Vector3 forward = transform.TransformDirection(Vector3.forward); // get the forward direction vector

        if (Physics.Raycast(transform.position, forward, out Hit, rayLength, LayerMaskInteract.value))
        {
            if (Hit.collider.CompareTag("InteractableObj"))
            {
                Debug.Log("NAME IS " + Hit.collider.gameObject.name);
                if (!CompleteOnce)
                {
                    RaycastedObject = Hit.collider.gameObject.GetComponent<objectController>();
                    RaycastedObject.ShowObjName();
                    Debug.Log("Raycast has been shot");
                    InteractInZone = true;
                    ChangeCrosshair(true);
                    
                }
               
                if(InteractInZone == true && (Hit.collider.name.Equals("LF_Door") || Hit.collider.name.Equals("RF_Door")) &&Input.GetKeyDown(KeyCode.F))
                {

                    Activate_Car_Cam.ActivateCam();
                }
                isCrosshairActive = true;
                CompleteOnce = true;
                


                LightSwitch();
                Move_Seat_1();
                Move_Seat_2();
                CheckObjects();

            }


            if (Hit.collider.CompareTag("Collectible"))
            {
                if (!CompleteOnce)
                {
                    RaycastedObject = Hit.collider.gameObject.GetComponent<objectController>();
                    RaycastedObject.ShowObjName();
                    RaycastedObject.ShowObjDescription();
                    Debug.Log("Raycast has been shot");
                    isCollectible_1 = true;
                    InteractChangeCrosshair(true);

                }
                if (isCollectible_1 == true)
                {
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        Debug.Log("Collectible_1");
                        SaveEvidence();
                      
                    }
                }
                isCrosshairActive = true;
                CompleteOnce = true;



            }
            
            if (Hit.collider.CompareTag("Door_Activate"))
            {
                if (!CompleteOnce)
                {

                    RaycastedObject = Hit.collider.gameObject.GetComponent<objectController>();
                    RaycastedObject.ShowObjName();
                    Debug.Log("Raycast has been shot");
                    ChangeCrosshair(true);
                    PlayerIsCollidingWithDoor = true;
                }

                if (PlayerIsCollidingWithDoor && Input.GetKey(KeyCode.F))
                {
                    Door_animation = Hit.collider.gameObject.GetComponent<Door_animation>();
                    Door_animation.PlayDoorOpen();
                    DoorAudioOpenPlayed = true;
                }
                if(PlayerIsCollidingWithDoor == false && DoorAudioOpenPlayed == true)
                {
                    Door_animation = Hit.collider.gameObject.GetComponent<Door_animation>();
                    Door_animation.PlayDoorClose();
                    DoorAudioOpenPlayed = false;

                }

                isCrosshairActive = true;
                CompleteOnce = true;
  
            }

            if (Hit.collider.CompareTag("Discuss_Activate"))
            {
                Debug.Log("HIT is Colliding with " + Hit.collider.tag);

                if (In_Zone == true)
                {
                    Debug.Log("In_Zone = true");
                    if (!CompleteOnce)
                    { 
                        RaycastedObject = Hit.collider.gameObject.GetComponent<objectController>();
                        RaycastedObject.ShowObjName();
                        Debug.Log("Raycast has been shot");
                        DiscussChangeCrosshair(true);

                    
                    }

                    isCrosshairActive = true;
                    CompleteOnce = true;
                }

            }

        }

        if ((Physics.Raycast(transform.position, forward, out Hit, rayLength, LayerMaskInteract_2.value)))
        {
            if (Hit.collider.CompareTag("Collectible"))
            {
                if (!CompleteOnce)
                {
                    RaycastedObject = Hit.collider.gameObject.GetComponent<objectController>();
                    RaycastedObject.ShowObjName();
                    RaycastedObject.ShowObjDescription();
                    Debug.Log("Raycast has been shot");
                    isCollectible_2 = true;
                    InteractChangeCrosshair(true);

                }
                if (isCollectible_2 == true)
                {
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        SaveEvidence();
                    }
                }
                isCrosshairActive = true;
                CompleteOnce = true;


            }

        }

        if ((Physics.Raycast(transform.position, forward, out Hit, rayLength, LayerMaskInteract_3.value)))
        {
            if (Hit.collider.CompareTag("Collectible"))
            {
                if (!CompleteOnce)
                {
                    RaycastedObject = Hit.collider.gameObject.GetComponent<objectController>();
                    RaycastedObject.ShowObjName();
                    RaycastedObject.ShowObjDescription();
                    Debug.Log("Raycast has been shot");
                    isCollectible_3 = true;
                    InteractChangeCrosshair(true);

                }

                if (Hit.collider.gameObject.name.Equals("Description_Of_Victim (1)"))
                {

                        Image_Of_Victim_Neck.SetActive(true);

   
                }
                else
                {
                    Image_Of_Victim_Neck.SetActive(false);

                }




                if (isCollectible_3 == true)
                {
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        SaveEvidence();
                    }
                }

                
                isCrosshairActive = true;
                CompleteOnce = true;



            }

        }

        else
        {
            if (isCrosshairActive)
            {
                RaycastedObject.HideObjectName();
                RaycastedObject.HideObjectDescription();
                ChangeCrosshair(false);
                InteractChangeCrosshair(false);
                DiscussChangeCrosshair(false);
                CompleteOnce = false;
                isCollectible_1 = false;
                isCollectible_2 = false;
                isCollectible_3 = false;

            }

        }

        if ((Physics.Raycast(transform.position, forward, out Hit, rayLength, LayerMaskInteract_4.value)))
        {
            if (Hit.collider.CompareTag("InteractableObj"))
            {
                if (!CompleteOnce)
                {
                    RaycastedObject = Hit.collider.gameObject.GetComponent<objectController>();
                    RaycastedObject.ShowObjName();
                    Debug.Log("Raycast has been shot");
                    isCollectible_3 = true;
                    InteractChangeCrosshair(true);

                }

                isCrosshairActive = true;
                CompleteOnce = true;


            }

        }

        else
        {
            if (isCrosshairActive)
            {
                RaycastedObject.HideObjectName();
                RaycastedObject.HideObjectDescription();
                ChangeCrosshair(false);
                InteractChangeCrosshair(false);
                DiscussChangeCrosshair(false);
                CompleteOnce = false;
                isCollectible_1 = false;
                isCollectible_2 = false;
                isCollectible_3 = false;

            }

        }



    }
    private void ChangeCrosshair(bool isOn)
    {
        if (isOn && !CompleteOnce)
        {
            //Crosshair.sprite = Default_Icon;
            Crosshair.GetComponent<Image>().color = new Color32(126, 133, 255, 255);

        }
        else
        {
            //Crosshair.sprite = Default_Icon;
            Crosshair.color = Color.white;
            Crosshair.GetComponent<Image>().color = new Color(Crosshair.color.r, Crosshair.color.g, Crosshair.color.b, Opacity);
            isCrosshairActive = false;
            PlayerIsCollidingWithDoor = false;
            InteractInZone = false;

        }
    }

    private void InteractChangeCrosshair(bool isOn)
    {
        if (isOn && !CompleteOnce)
        {
           // Crosshair.sprite = Grab_Icon;
            Crosshair.GetComponent<Image>().color = new Color32(221, 82, 70, 255);
            Interaction = true;

        }
        else
        {
            //Crosshair.sprite = Default_Icon;
            Crosshair.color = Color.white;
            Crosshair.GetComponent<Image>().color = new Color(Crosshair.color.r, Crosshair.color.g, Crosshair.color.b, Opacity);
            isCrosshairActive = false;
            Interaction = false;
        }
    }
    

    private void DiscussChangeCrosshair(bool isOn)
    {
        if (isOn && !CompleteOnce)
        {
            Crosshair.sprite = Talk_Icon;
            Crosshair.GetComponent<Image>().color = new Color32(126, 133, 255, 255);
            Interaction = true;

        }
        else
        {
            Crosshair.sprite = Default_Icon;
            Crosshair.color = Color.white;
            Crosshair.GetComponent<Image>().color = new Color(Crosshair.color.r, Crosshair.color.g, Crosshair.color.b, Opacity);
            isCrosshairActive = false;
            Interaction = false;
        }
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(3f);
        Destroy(Hit.collider.gameObject);
        Debug.Log(Hit.collider.gameObject);
    }

    public void Display_Message()
    {
        PickUpMesage.SetActive(true);
        AS.Play();
        Invoke("Hide", 3f);
        Collectible.Collected = false;
        Send_To_Google_Form.Collected = false;
        Store_Evidence = false;
        Debug.Log("Display_Message has been called");
    }

    private void Hide()
    {
        PickUpMesage.SetActive(false);
    }

    private void LightSwitch()
    {
        if (Hit.collider.gameObject.name.Contains("Indoor_Car_Light"))
        {
            if (LightIsOn == false && Input.GetKeyDown(KeyCode.F))
            {
                Activate_GameObject = Hit.collider.gameObject.GetComponent<Activate_GameObject>();
                Activate_GameObject.TurnLightOn();
                LightIsOn = true;

            }
            else if (LightIsOn == true && Input.GetKeyDown(KeyCode.F))
            {
                Activate_GameObject = Hit.collider.gameObject.GetComponent<Activate_GameObject>();
                Activate_GameObject.TurnLightOff();
                LightIsOn = false;

            }
        }
    }

    private void Move_Seat_1()
    {
        if (Hit.collider.gameObject.name.Contains("Seat1"))
        {
            if (Input.GetKeyDown(KeyCode.F) && SeatForward == false) 
            {
                Debug.Log("Move The Door");
                Trigger_Animation = Hit.collider.gameObject.GetComponent<Trigger_Animation>();
                Trigger_Animation.Move_Car_Door();
                SeatForward = true;
            }
            else if (SeatForward == true && Input.GetKeyDown(KeyCode.F))
            {
                Trigger_Animation = Hit.collider.gameObject.GetComponent<Trigger_Animation>();
                Trigger_Animation.Move_Car_Door_Back();
                Debug.Log("Move The Door");
                SeatForward = false;
            }
        }
    }

    private void Move_Seat_2()
    {
        if (Hit.collider.gameObject.name.Contains("Seat2"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Trigger_Animation = Hit.collider.gameObject.GetComponent<Trigger_Animation>();
                Trigger_Animation.Move_Car_Door();
                Debug.Log("Bring_Seat_Up");
                Destroy(Hit.collider.gameObject);
            }
        }
    }
    private void SaveEvidence()
    {
        Collectible.SaveCollectible(Hit.collider.name.ToString());
        FileDownload.DownloadToFile(Retrieve_Text.NameStr, Hit.collider.name.ToString(), "EvidenceCollected.txt");
        Send_To_Google_Form.Send(Retrieve_Text.NameStr, Hit.collider.name.ToString());
        Store_Evidence = true;
        Display_Note_Pad_Evidence = Hit.collider.gameObject.GetComponent<Display_Note_Pad_Evidence>();
        Display_Note_Pad_Evidence.Display();
        Display_Message();
        Debug.Log("Saving Evidence");
        Hit.collider.gameObject.SetActive(false);

    }
    

    private void CheckObjects()
    {
        if (Hit.collider.gameObject.name == "Clutch")
        {
            LookAtClutch = true;
            Debug.Log("Clutch");
        }
        if (Hit.collider.gameObject.name == "Glasses")
        {
            LookAtGlasses = true;
            Debug.Log("Glasses");
        }
        if (Hit.collider.gameObject.name == "Pen")
        {
            LookAtPen = true;
            Debug.Log("Pen");
        }
        if (Hit.collider.gameObject.name == "lighter")
        {
            LookAtLighter = true;
            Debug.Log("Lighter");
        }

        if (LookAtClutch == true && LookAtGlasses == true && LookAtPen == true && LookAtLighter == true && Collected == false)
        {
            //Evidence.GetComponent<Display_Note_Pad_Evidence>().enabled = true;
            Evidence.GetComponent<Display_Note_Pad_Evidence>().Display();


            Collectible.SaveCollectible("No weapons or belongings found");
            FileDownload.DownloadToFile(Retrieve_Text.NameStr, "No weapons or belongings found", "evidence.txt");
            Send_To_Google_Form.Send(Retrieve_Text.NameStr, "No weapons or belongings found");
            Store_Evidence = true;
            Display_Message();
            //Destroy(Hit.collider.gameObject);

            
            Collected = true;
        }

    }


}
