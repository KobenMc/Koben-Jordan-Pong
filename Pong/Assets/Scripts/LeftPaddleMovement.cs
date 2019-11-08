using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        ControlByLeftPlayer();
    }
    void ControlByLeftPlayer()
    {
        //Set speed
        float movementSpeed = 5f;
        //Move when pressing W or S
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, movementSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, -movementSpeed * Time.deltaTime, 0);
        }

    }
}
