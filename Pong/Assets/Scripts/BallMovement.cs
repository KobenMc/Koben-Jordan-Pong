using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class RotationMatrix2D
{
    public RotationMatrix2D(float Angle)
    {
        mMatrix = new float[2, 2];
        float sinTheta = Mathf.Sin(Angle);
        float cosTheta = Mathf.Cos(Angle);
        mMatrix[0, 0] = cosTheta;
        mMatrix[0, 1] = -sinTheta;
        mMatrix[1, 0] = sinTheta;
        mMatrix[1, 1] = cosTheta;
    }
}
public class BallMovement : MonoBehaviour
{
    [SerializeField] private float BallSpeed = 10.0f;
    Rigidbody2D myBody;
    // Use this for initialization
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        float launchAngle = Random.Range(-50, 50);
        Vector2 launchVec = new Vector2(1, 0);
        float goesLeft = Random.Range(-1, 1);
        if (goesLeft > 0.0f)
        {
            launchAngle += 180.0f;
            launchVec = Math.ApplyRotationTo(launchVec, launchAngle);
            myBody.velocity = launchVec; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        BallBounce(); 
    }
    void BallBounce()
    {
        if (transform.position.y > 3.45f)
        {
            myBody.velocity = new Vector2(myBody.velocity.x, -myBody.velocity.y);
        }
        if (transform.position.y > -3.45f)
        {
            myBody.velocity = new Vector2(myBody.velocity.x, -myBody.velocity.y);
        }
    }
}
