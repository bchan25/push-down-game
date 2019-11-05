using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    [SerializeField]
    private GameObject mainMenuCanvas;
    [SerializeField]
    private GameObject gameOverCanvas;
    [SerializeField]
    private GameObject levelCompleteCanvas;
    [SerializeField]
    private GameObject gameGuiCanvas;
    [SerializeField]
    private GameObject characterSelectionCanvas;

    private void TurnOnCanvas(GameObject canvas)
    {
        canvas.SetActive(true);
    }

    private void TurnOffCanvas(GameObject canvas)
    {
        canvas.SetActive(false);
    }


    // Main Menu
    public void MainMenuEnable()
    {
        TurnOnCanvas(mainMenuCanvas);
    }

    public void MainMenuDisable()
    {
        TurnOffCanvas(mainMenuCanvas);
    }

    // Game Over
    public void GameOverEnable()
    {
        TurnOnCanvas(gameOverCanvas);
    }

    public void GameOverDisable()
    { 
        TurnOffCanvas(gameOverCanvas);
    }

    // Level Complete
    public void LevelCompleteEnable()
    {
        TurnOnCanvas(levelCompleteCanvas);
    }

    public void LevelCompleteDisable()
    {
        TurnOffCanvas(levelCompleteCanvas);
    }

    // Game GUI
    
    public void GameGuiEnable()
    {
        TurnOnCanvas(gameGuiCanvas);
    }

    public void GameGuiDisable()
    {
        TurnOffCanvas(gameGuiCanvas);
    }

    // Character Selection

    public void CharacterSelectionCanvasEnable()
    {
        TurnOnCanvas(characterSelectionCanvas);
    }

    public void CharacterSelectionCanvasDisable()
    {
        TurnOffCanvas(characterSelectionCanvas);
    }

}
