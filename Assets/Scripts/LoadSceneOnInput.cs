﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour
{

    // sceneName to use the same script in different scenes
    public static string sceneName;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Changes to a different scene depending on the current one
        // Previous functionality only changed current scene to "Play"
        if (Input.GetAxis("Submit") == 1)
        {
            sceneName = SceneManager.GetActiveScene().name;
            if (sceneName == "Title")
            {
                SceneManager.LoadScene("Play");
            }
            else if (sceneName == "GameOver")
            {
                SceneManager.LoadScene("Title");
            }
        }
    }
}