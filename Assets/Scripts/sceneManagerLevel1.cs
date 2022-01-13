using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManagerLevel1 : MonoBehaviour
{
    public scoreScript scoreManager;

    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if(sceneName == "Level 1")
        {
            if(scoreScript.scoreValue == 300)
            {
                SceneManager.LoadScene(2);
                scoreScript.scoreValue = 0;
            }
        }
        if(sceneName == "Level 2")
        {
            if (scoreScript.scoreValue >= 150)
            {
                Destroy(GameObject.FindWithTag("Destroy"));
            }
            if (scoreScript.scoreValue == 300)
            {
                SceneManager.LoadScene(4);
                scoreScript.scoreValue = 0;
            }
        }
        if(sceneName=="Level 3")
        {
            if (scoreScript.scoreValue == 150)
            {
                SceneManager.LoadScene("Win");
                scoreScript.scoreValue = 0;
                
            }
        }
    }
        
        
}