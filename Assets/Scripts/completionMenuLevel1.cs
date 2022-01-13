using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class completionMenuLevel1 : MonoBehaviour
{
    
    public void Continue()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Continue2()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
