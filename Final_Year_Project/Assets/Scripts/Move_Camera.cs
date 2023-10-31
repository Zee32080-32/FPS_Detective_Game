using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Camera : MonoBehaviour
{
    private float speed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.S))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            pos.z -= speed * Time.deltaTime;
        }
        transform.position = pos;
    }
}
