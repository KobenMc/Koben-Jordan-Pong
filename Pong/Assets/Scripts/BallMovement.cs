using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D myBody;
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
        myBody.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            myBody.AddForce(new Vector2(20, -15));
        }
        else
        {
            myBody.AddForce(new Vector2(-20, -15));
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = myBody.velocity.x;
            vel.y = (myBody.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            myBody.velocity = vel;
        }
        if (coll.collider.CompareTag("Border"))
        {
            Vector2 vel;
            vel.x = myBody.velocity.x;
            vel.y = (myBody.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            myBody.velocity = vel;
        }
    }
}
