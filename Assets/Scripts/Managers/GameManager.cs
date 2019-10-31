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

        PauseGame();
    }

   
    void Update()
    {
        // If game hasn't started and mouse touch screen
        if(startGame == false)
        {
            
            if (Input.GetMouseButtonDown(0) && gameOver == false)
            {
                StartGame();

            }
        }

    }

    public void StartGame()
    {
        startGame = true;
        playerController.SetOnTouch();
        sceneManager.MainMenuDisable();
        Time.timeScale = 1f;
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

}
