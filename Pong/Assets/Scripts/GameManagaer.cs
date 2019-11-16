using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagaer : MonoBehaviour
{
    public BallMovement Ball = null;
    public TMPro.TextMeshProUGUI LeftScore = null;
    public TMPro.TextMeshProUGUI RightScore = null;

    // Update is called once per frame
    void Update()
    {
        if (Ball != null)
        {
            if (LeftScore != null)
            {
                LeftScore.text = Ball.LeftScore.ToString();
            }
            if (RightScore != null)
            {
                RightScore.text = Ball.RightScore.ToString();
            }
        }
        if (Ball.LeftScore == 10)
        {
            GetComponent<AudioSource>().Play();
        }
        if (Ball.RightScore == 10)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
