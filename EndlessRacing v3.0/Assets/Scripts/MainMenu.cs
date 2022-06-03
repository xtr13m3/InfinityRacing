using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool isStart;
    public bool isHighscores;
    public bool isQuit;

    private void OnMouseUp()
    {
        if(isStart)
        {
            SceneManager.LoadScene("MainScene");
        }

        if(isHighscores)
        {
            SceneManager.LoadScene("Highscores");
        }

        if(isQuit)
        {
            Application.Quit();
        }
    }
}
