using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreScript : MonoBehaviour
{
    public static float scoreValue = 0;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();

    }

    
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }

}
