using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Conditions for a game over are in this script

public class GameOverConditions : MonoBehaviour
{
    // Use this for initialization
    public static Vector3 cameraPosition;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cameraPosition = Camera.main.gameObject.transform.position;
        if (cameraPosition.y < -25)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}