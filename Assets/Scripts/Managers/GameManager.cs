﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    // References
    [SerializeField]
    private SceneManager sceneManager;
    [SerializeField]
    private PlayerController playerController;
    [SerializeField]
    private LevelManager levelManager;
    [SerializeField]
    private ScoreManager scoreManger;

    [SerializeField]
    private int targetFrameRate = 30;

    public bool gameOver = false;
    public bool startGame = false;

    // TODO: GUI MANAGER

    // Progress Bar
    public Slider progressBar;
    // Distance from the start
    float distance;
    // Hold the distance travel of the finish line
    float distanceTravelled = 0;
    // store the recent position of the finish line
    Vector3 finishLineLastPos;

    // Game GUI
    public Text currentLevelLabel;
    public Text nextLevelLabel;

    // Game Over GUI
    public Text scoreLabelText;
    public Text bestLabelText;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
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

    private void Update()
    {
        if (startGame)
        {
            distanceTravelled += Vector3.Distance(levelManager.GetTheFinishLine().position, finishLineLastPos);
            finishLineLastPos = levelManager.GetTheFinishLine().position;
            // Update the progress bar * 1 give value 0 to 1
            progressBar.value = (distanceTravelled / distance) * 1;
        }

    }

    // Game States

    public void PrepareGame()
    {
        PauseGame();
        gameOver = false;
        // Set up the game level
        // Player at start position
        playerController.ResetPlayer();
        levelManager.LoadLevel();

        distanceTravelled = 0;

        // Process Bar
        distance = Vector3.Distance(playerController.transform.position, levelManager.GetTheFinishLine().position);
        finishLineLastPos = levelManager.GetTheFinishLine().position;

    }


    public void StartGame()
    {
        startGame = true;
        playerController.SetTouchOn();
        sceneManager.MainMenuDisable();
        sceneManager.GameGuiEnable();

        // Update GUI
        currentLevelLabel.text = levelManager.GetCurrentLevel();
        nextLevelLabel.text = levelManager.GetNextLevel();

        Time.timeScale = 1f;

    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        gameOver = true;

        // This can't be here until game refresh
        startGame = false;
        progressBar.value = 0;
        playerController.DisableTouch();
        sceneManager.GameGuiDisable();
        sceneManager.GameOverEnable();

        // Score
        // TODO High Score check here and display score gameover screen
        scoreManger.IsItHighScore();
        scoreLabelText.text = scoreManger.GetCurrentScore();
        bestLabelText.text = scoreManger.GetBestScore();


    }

    public void LevelComplete()
    {
        Debug.Log("Completed Level");
        gameOver = true;

        // TEST
        startGame = false;
        progressBar.value = 0;
        playerController.DisableTouch();
        sceneManager.GameGuiDisable();
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

        // Reset Score
        scoreManger.ResetScore();

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
