using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{

    // Reference to CoinManager
    private CoinManager coinManager;
    private UIManager uiManager;

    // Coin value
    [SerializeField]
    private int coinValue = 1;

    void Start()
    {
        coinManager = FindObjectOfType<CoinManager>();
        uiManager = FindObjectOfType<UIManager>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            coinManager.Add(coinValue);
            uiManager.UpdateCoinLabel();
            Destroy(gameObject);
        }
    }

}
