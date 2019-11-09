using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleMovement : MonoBehaviour
{
    //Set speed
    float movementSpeed = 5f;
    // Update is called once per frame
    void Update()
    {
        ControlByLeftPlayer();
    }
    void ControlByLeftPlayer()
    {
        //Find position on Y axis
        float VerticalPosition = transform.position.y;
        //Check if paddle has reached border
        if (VerticalPosition < 3.35)
        {
            //Move when pressing W or S
            if (Input.GetKey(KeyCode.W))
            {
                transform.position = transform.position + new Vector3(0, movementSpeed * Time.deltaTime, 0);
            }
        }
        if (VerticalPosition > -3.35)
        {
            if (Input.GetKey(KeyCode.S))
            {
               transform.position = transform.position + new Vector3(0, -movementSpeed * Time.deltaTime, 0);
            }
        }

    }
}
