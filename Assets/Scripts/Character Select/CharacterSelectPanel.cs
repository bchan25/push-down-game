using System.Collections;
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

    public bool unlocked = false;
    public int cost = 0;
    public bool videoReward = false;

    void Start()
    {
        sceneManager = FindObjectOfType<SceneManager>();
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
                Debug.Log("Cost you this amount of coins " + cost);
            }
        }
    }
}
