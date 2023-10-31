using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectController : MonoBehaviour
{

    [SerializeField]
    private string ObjectName;

    [SerializeField]
    private string ObjectDescription;

    [SerializeField]
    private InspectController InspectController;
   
    Collectible Collectible;
    PickUpAlert PickUpAlert;

    void Start()
    {
       
        Collectible = FindObjectOfType<Collectible>();
        PickUpAlert = FindObjectOfType<PickUpAlert>();
    }

    public void ShowObjName()
    {
        InspectController.ShowObjName(ObjectName);
        Debug.Log("Name is being shown");
        
    
            
    }

    public void HideObjectName()
    {

            InspectController.HideObjName();
        
        

    }

    public void ShowObjDescription()
    {

        InspectController.ShowObjDescription(ObjectDescription);

    }


    public void HideObjectDescription()
    {
        InspectController.HideObjDescription();

    }

}
