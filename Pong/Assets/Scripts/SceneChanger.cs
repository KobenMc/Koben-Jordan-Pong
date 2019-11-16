using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GoToFinalScene()
    {
        SceneManager.LoadScene("Koben-Jordan-Pong");
    }

    public void GoToOriginScene()
    {
        SceneManager.LoadScene("FinalScene");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
