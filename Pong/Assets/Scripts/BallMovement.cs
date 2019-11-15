using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public int Hits; 
    int LeftScore;
    int RightScore; 
    private Rigidbody2D myBody;
    
    float speed; 
    // Use this for initialization

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 1);
    }

    void Restart()
    {
        RightScore = 0;
        LeftScore = 0;
        Hits = 0; 
        Reset();
        Invoke("GoBall", 1);
    }

    void Reset()
    {
        transform.position = new Vector3 (0, 0,0);
        GoBall();
    }

    void GoBall()
    {
        speed = 8; 
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("RightWall"))
        {
            LeftScore += 1;
            Reset();
        }
        if (collision.gameObject.tag == "LeftWall")
        {
            RightScore += 1;
            Reset();
        }
        if (collision.gameObject.tag == "Player")
        {
            Hits++;
            speed += .2f;
        }
    }
}