﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectPanel : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer character;
    [SerializeField]
    private Text buttonText;

    private GameObject player;
    private SpriteRenderer playerSpriteRenderer;

    private SceneManager sceneManager;
    private CoinManager coinManager;

    public bool unlocked = false;
    public int cost = 0;
    public bool videoReward = false;

    void Start()
    {
        sceneManager = FindObjectOfType<SceneManager>();
        coinManager = FindObjectOfType<CoinManager>();

        player = GameObject.FindGameObjectWithTag("Player");
        playerSpriteRenderer = player.GetComponent<SpriteRenderer>();

        SetUpButtonText();
    }

    private void SetUpButtonText()
    {
        if (unlocked)
        {
            buttonText.text = "Select";
        }
        else
        {
            if (videoReward)
            {
                buttonText.text = "Video Reward";
            }
            else
            {
                buttonText.text = cost + " coins unlock";
            }
        }
    }

    public void ButtonPressed()
    {
        if (unlocked)
        {

            playerSpriteRenderer.sprite = character.sprite;
            playerSpriteRenderer.color = character.color;

            // Disable Screen
            sceneManager.CharacterSelectionCanvasDisable();
        }
        else
        {
            if (videoReward)
            {
                buttonText.text = "Video Reward";
            }
            else
            {
                if(coinManager.Remove(cost))
                {
                    unlocked = true;
                    playerSpriteRenderer.sprite = character.sprite;
                    playerSpriteRenderer.color = character.color;

                    SetUpButtonText();
                    // Disable Screen
                    sceneManager.CharacterSelectionCanvasDisable();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
