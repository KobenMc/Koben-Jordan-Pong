using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddleMovement : MonoBehaviour
{
    //Set speed 
    float movementSpeed = 5f;
    void Update()
    {
        ControlByRightPlayer();
    }
    
    void ControlByRightPlayer()
    {
        //Find position on Y axis
        float VerticalPosition = transform.position.y;
        //Check if paddle has reached border
        if (VerticalPosition < 3.35)
        {
            //Move when pressing W or S
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position = transform.position + new Vector3(0, movementSpeed * Time.deltaTime, 0);
            }
        }
        if (VerticalPosition > -3.35)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position = transform.position + new Vector3(0, -movementSpeed * Time.deltaTime, 0);
            }
        }

    }
}