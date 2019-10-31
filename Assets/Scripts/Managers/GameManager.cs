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

    // Update is called once per frame
    void Update()
    {
        // If game hasn't started and mouse touch screen
        if (startGame == false && Input.GetMouseButtonDown(0))
        {
            StartGame();
            
        }
    }

    public void StartGame()
    {
        startGame = true;
        sceneManager.MainMenuDisable();
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        gameOver = true;

        // This can't be here until game refresh
        startGame = false;

        sceneManager.GameOverEnable();
    }

    public void LevelComplete()
    {
        Debug.Log("Completed Level");

        sceneManager.LevelCompleteEnable();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

}
