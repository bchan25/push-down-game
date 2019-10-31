using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

    // References
    [SerializeField]
    private SceneManager sceneManager;
    [SerializeField]
    private PlayerController playerController;
    [SerializeField]
    private LevelManager levelManager;

    [SerializeField]
    private int targetFrameRate = 30;

    public bool gameOver = false;
    public bool startGame = false;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        // Initial setup
        Application.targetFrameRate = targetFrameRate;

        PrepareGame();
    }

    public void PrepareGame()
    {
        PauseGame();
        gameOver = false;
        // Set up the game level
        // Player at start position
        playerController.ResetPlayer();
        // Level at start position
        levelManager.LoadLevel();
    }


    public void StartGame()
    {
        startGame = true;
        playerController.SetOnTouch();
        sceneManager.MainMenuDisable();
        Time.timeScale = 1f;

        // Enable Game GUI
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        gameOver = true;

        // This can't be here until game refresh
        startGame = false;
        playerController.DisableTouch();
        sceneManager.GameOverEnable();
    }

    public void LevelComplete()
    {
        Debug.Log("Completed Level");
        gameOver = true;

        // TEST
        startGame = false;
        playerController.DisableTouch();

        sceneManager.LevelCompleteEnable();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }


    public void TapToRestart()
    {
        sceneManager.GameOverDisable();
        sceneManager.MainMenuEnable();

        // Destroy Level
        levelManager.DestroyCurrentLevel();
        // Prepare Game
        PrepareGame();
        
    }

    public void NextLevel()
    {
        sceneManager.LevelCompleteDisable();
        sceneManager.MainMenuEnable();

        // Destroy Level
        levelManager.DestroyCurrentLevel();

        // Increase Level
        levelManager.LevelUp();
        PrepareGame();
    }

}
