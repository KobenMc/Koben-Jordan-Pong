using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddleMovement : MonoBehaviour
{
    void Update()
    {

        ControlByRightPlayer();
    }
    
    void ControlByRightPlayer()
    {
        //Set speed and get y axis
        float verticalInput = Input.GetAxis("Vertical");
        float movementSpeed = 5f;
        //Move when pressing W or S
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + new Vector3(0, verticalInput * movementSpeed * Time.deltaTime, 0);
        }
    }
}