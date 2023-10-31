using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    [SerializeField]
    private float HSPEED = 2;
    
    [SerializeField]
    private float VSPEED = 2;

    [SerializeField]
    private float yaw = 0.0f;

    public Transform mainCamera;
    private Quaternion initRotation;

    [SerializeField]
    private float Pitch = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        yaw = mainCamera.rotation.eulerAngles.y;
        Pitch = mainCamera.rotation.eulerAngles.x;
    }
    // Update is called once per frame
    void Update()
    {
        yaw += HSPEED * Input.GetAxis("Mouse X");
        Pitch -= VSPEED * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(Pitch, yaw, 0);

    }

}
