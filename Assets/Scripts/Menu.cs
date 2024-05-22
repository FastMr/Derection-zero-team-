using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("Obuchenie");
    }

    public void Autors()
    {
        SceneManager.LoadScene("Autors");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}