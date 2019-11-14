using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D myBody;
    float speed = 8; 
    // Use this for initialization
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    void Restart()
    {
        Reset();
        Invoke("GoBall", 1);
    }

    void Reset()
    {
        transform.position = Vector2.zero;
    }

    void GoBall()
    {
        float rand = Random.Range(0, 2); 
        if (rand <1)
        {
            float theta = Random.Range(-35.0f, 35.0f);
            Vector2 newVelocity = Quaternion.AngleAxis(theta, new Vector3(0, 0, 1)) * new Vector2(1, 0);
            myBody.velocity = newVelocity * speed;
        }
        else
        {
            float theta = Random.Range(-35.0f, 35.0f);
            Vector2 newVelocity = Quaternion.AngleAxis(theta, new Vector3(0, 0, 1)) * new Vector2(-1, 0);
            myBody.velocity = newVelocity * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = myBody.velocity.x;
            vel.y = (myBody.velocity.y / 1) + (coll.collider.attachedRigidbody.velocity.y / 3);
            myBody.velocity = vel;
        }
        if (coll.collider.CompareTag("Border"))
        {
            Vector2 vel;
            vel.x = myBody.velocity.x;
            vel.y = (myBody.velocity.y / 1) + (coll.collider.attachedRigidbody.velocity.y / 3);
            myBody.velocity = vel;
        }
    }
}
