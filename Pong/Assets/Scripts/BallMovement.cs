using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    float forceValue = 5.0f;

    Rigidbody2D myBody;
    // Use this for initialization
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        myBody.AddForce(new Vector2(forceValue * 50, 50));
    }

    // Update is called once per frame
    void Update()
    {
        BallBounce(); 
    }
    void BallBounce()
    {
        if ()
        {

        }
    }
}
