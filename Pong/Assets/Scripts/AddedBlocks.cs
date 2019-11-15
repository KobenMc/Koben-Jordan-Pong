using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddedBlocks : MonoBehaviour
{
    BallMovement Bm;
    // Start is called before the first frame update
    void Start()
    {
        Bm = FindObjectOfType<BallMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
