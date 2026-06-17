using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void StartGame() 
    {
        SceneManager.LoadScene("SampleScene");


    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void WinScene ()
    {
        SceneManager.LoadScene("WinScene");
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("StartMenu");

    }




}   