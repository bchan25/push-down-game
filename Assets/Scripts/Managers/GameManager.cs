using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager _instance;

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
        Time.timeScale = 1f;
    }

    public void GameOver()
    {

    }

    public void LevelComplete()
    {
        Debug.Log("Completed Level");
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

}
