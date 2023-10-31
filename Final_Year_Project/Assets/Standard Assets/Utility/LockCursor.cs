using UnityEngine;

public class LockCursor : MonoBehaviour
{
    Vector3 mousePos; 
    void Update()
    {
        mousePos = Input.mousePosition;
        Debug.Log("The mouse pos is " + mousePos);
    }
}