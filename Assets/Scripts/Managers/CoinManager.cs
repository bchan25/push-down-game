using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    [SerializeField]
    private UIManager uiManager;

    private int initialCoins = 0;
    private int coins;


    private void Start()
    {
        ResetCoins();
        uiManager.UpdateCoinLabel();
    }

    private void ResetCoins()
    {
        // Testing need to change when there is a saving system
        coins = initialCoins;
    }

    public void Add(int amount)
    {
        coins += amount;
    }

    public bool Remove(int amount)
    {
        if (amount > coins)
        {
            return false;
        }

        coins -= amount;
        uiManager.UpdateCoinLabel();
        return true;
    }

    public int GetCoinTotal()
    {
        return coins;
    }

    public string GetCurrentCoins()
    {
        return coins.ToString();
    }


}
