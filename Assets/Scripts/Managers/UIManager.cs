using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private ScoreManager scoreManager;

    [SerializeField]
    private Text scoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreLabel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScoreLabel()
    {
        scoreLabel.text = scoreManager.GetCurrentScore();
    }
}
