using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenes : MonoBehaviour
{

    public void IntroGame()
    {
        SceneManager.LoadScene("1Intro");
    }

    public void HighScores()
    {
        SceneManager.LoadScene("2HighScores");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("3Game");
    }
    public void ExitScreen()
    {
        SceneManager.LoadScene("4Exit");
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}