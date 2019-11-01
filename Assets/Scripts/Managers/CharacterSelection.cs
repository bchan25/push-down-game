using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> unlockCharacters;

    public GameObject player;
    private SpriteRenderer playerSpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        playerSpriteRenderer = player.GetComponent<SpriteRenderer>();

        // Test
        playerSpriteRenderer.sprite = unlockCharacters[1].GetComponent<SpriteRenderer>().sprite;
        playerSpriteRenderer.color = unlockCharacters[1].GetComponent<SpriteRenderer>().color;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Test
            playerSpriteRenderer.sprite = unlockCharacters[0].GetComponent<SpriteRenderer>().sprite;
            playerSpriteRenderer.color = unlockCharacters[0].GetComponent<SpriteRenderer>().color;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Test
            playerSpriteRenderer.sprite = unlockCharacters[1].GetComponent<SpriteRenderer>().sprite;
            playerSpriteRenderer.color = unlockCharacters[1].GetComponent<SpriteRenderer>().color;
        }
    }
}
