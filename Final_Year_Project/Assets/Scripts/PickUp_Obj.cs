using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_Obj : MonoBehaviour
{
    [SerializeField]
    private Transform Destination;
    private bool Inspecting_Obj;
    private Vector3 Original_Position;

    [SerializeField]
    private float RotationSpeed;

    [SerializeField]
    private GameObject InspectObject_Panel;

    [SerializeField]
    private GameObject Main_Panel;

    Vector3 mPrePos = Vector3.zero;
    Vector3 mPosDelta = Vector3.zero;

    [SerializeField]
    private GameObject Evidence;

    // Start is called before the first frame update
    void Start()
    {
        Evidence.SetActive(false);
        InspectObject_Panel.SetActive(false);
        Original_Position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.transform.position = Destination.position;
            Inspecting_Obj = true;
            InspectObject_Panel.SetActive(true);
            Main_Panel.SetActive(false);
            Evidence.SetActive(true);
        }

        if (Input.GetMouseButton(0))
        {
            Rotate();
        }
        mPrePos = Input.mousePosition;
        //this.transform.parent = GameObject.Find("Object_Destination").transform;



        if (Input.GetKeyDown(KeyCode.X))
        {
            this.transform.position = Original_Position;
            Debug.Log("New position = " + this.transform.position);
            Main_Panel.SetActive(true);
            InspectObject_Panel.SetActive(false);
            Evidence.SetActive(false);
        }
    }
        
    

    void Rotate()
    {
        mPosDelta = Input.mousePosition - mPrePos;

        if (Vector3.Dot(transform.up, Vector3.up) >= 0)
        {
            transform.Rotate(transform.up, -Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
        }
        else
        {
            transform.Rotate(transform.up, Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);
        }

        transform.Rotate(Camera.main.transform.right, Vector3.Dot(mPosDelta, Camera.main.transform.up), Space.World);



    }
}
