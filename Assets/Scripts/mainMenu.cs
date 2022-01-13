using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Level 1");
        if (pauseMenu.gameIsPaused)
        {
            pauseMenu.gameIsPaused = false;
        }
    }

    public void quitGame()
    {
        Application.Quit();
    }
}