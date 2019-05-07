using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartQuit : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadScene("2HighScores");
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void StartPlay()
    {
        SceneManager.LoadScene("3Game");
    }

    public void exitPlay()
    {
        SceneManager.LoadScene("4Exit");
    }

    public void replay()
    {
        SceneManager.LoadScene("1Intro");
    }
}