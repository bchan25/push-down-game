using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Reference
    [SerializeField]
    private LevelManager levelManager;
    [SerializeField]
    private UIManager uiManager;


    [SerializeField]
    private int currentScore = 0;

    private int bestScore = 0;


  

    public void AddScore()
    {
        currentScore += levelManager.GetCurrentLevelInt();
        uiManager.UpdateScoreLabel();
    }

    // Game Over
    public void ResetScore()
    {
        currentScore = 0;
        uiManager.UpdateScoreLabel();
    }

    public void IsItHighScore()
    {
        if(currentScore > bestScore)
        {
            bestScore = currentScore;
        }
    }

    public string GetCurrentScore()
    {
        return currentScore.ToString();
    }

    public string GetBestScore()
    {
        return bestScore.ToString();
    }
}
