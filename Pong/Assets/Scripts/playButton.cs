using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class playButton : MonoBehaviour
{
    void OnMouseUp()
    {
        SceneManager.LoadScene("FinalScene", LoadSceneMode.Single);
    }

}

