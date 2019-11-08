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
        //Set speed 
        float movementSpeed = 5f;
        //Move when pressing W or S
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0,  movementSpeed * Time.deltaTime, 0);
        }
        if( Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + new Vector3(0, - movementSpeed * Time.deltaTime, 0);
        }
    }
}