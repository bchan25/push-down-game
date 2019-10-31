using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    public GameObject mainMenuCanvas;
    public GameObject gameOverCanvas;
    public GameObject levelCompleteCanvas;
    public GameObject gameGuiCanvas;

    // Main Menu
    public void MainMenuEnable()
    {
        mainMenuCanvas.SetActive(true);
    }

    public void MainMenuDisable()
    {
        mainMenuCanvas.SetActive(false);
    }

    // Game Over
    public void GameOverEnable()
    {
        gameOverCanvas.SetActive(true);
    }

    public void GameOverDisable()
    {
        gameOverCanvas.SetActive(false);
    }

    // Level Complete
    public void LevelCompleteEnable()
    {
        levelCompleteCanvas.SetActive(true);
    }

    public void LevelCompleteDisable()
    {
        levelCompleteCanvas.SetActive(false);
    }

    // Game GUI
    
    public void GameGuiEnable()
    {
        gameGuiCanvas.SetActive(true);
    }

    public void GameGuiDisable()
    {
        gameGuiCanvas.SetActive(false);
    }

}
