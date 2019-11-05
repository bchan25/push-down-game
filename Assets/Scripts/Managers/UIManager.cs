using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Score
    [SerializeField]
    private ScoreManager scoreManager;
    [SerializeField]
    private Text scoreLabel;

    // Coin
    [SerializeField]
    private CoinManager coinManager;
    [SerializeField]
    private Text coinLabel;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreLabel();
    }


    public void UpdateScoreLabel()
    {
        scoreLabel.text = scoreManager.GetCurrentScore();
    }

    public void UpdateCoinLabel()
    {
        coinLabel.text = coinManager.GetCurrentCoins();
    }
}
