using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Game Over canvas that is used for the game
    [Header("Game Over UI object for displaying Game Over Screen")]
    public GameObject gameOverCanvas;
    //Score canvas that is used for the game
    [Header("Score UI object used for displaying Score")]
    public GameObject scoreCanvas;
    //Spawner object that is used for the game
    [Header("Spawner Object for spawning objects in the game")]
    public GameObject spawner;

    void Start()
    {
        //Speed for the game is at a playing state
        Time.timeScale = 1;
        //Score is visible
        scoreCanvas.SetActive(true);
        //Game Over UI is invisible
        gameOverCanvas.SetActive(false);
        //The spawner is shown in the game
        spawner.SetActive(true);
    }

    public void GameOver()
    {
        //Game Over UI is visible
        gameOverCanvas.SetActive(true);
        //The spawner is now invisible in the game
        spawner.SetActive(false);
        //The speed for the game is now at a stopping state
        Time.timeScale = 0;
    }
}
