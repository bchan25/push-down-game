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
    private int currentScore = 0;

    private int bestScore = 0;

    // GUI
    public Text scoreLabel;

    private void Start()
    {
        scoreLabel.text = currentScore.ToString();
    }

    public void AddScore()
    {
        currentScore += levelManager.GetCurrentLevelInt();
        scoreLabel.text = currentScore.ToString();
    }

    // Game Over
    public void ResetScore()
    {
        currentScore = 0;
        scoreLabel.text = currentScore.ToString();
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
