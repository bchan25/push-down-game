using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{

    private int initialCoins = 0;
    private int coins;

    [SerializeField]
    private Text coinLabel;

    private void Start()
    {
        Reset();
        UpdateLabel();
    }

    private void Reset()
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
        UpdateLabel();
        return true;
    }

    public int GetCoinTotal()
    {
        return coins;
    }

    public void UpdateLabel()
    {
        coinLabel.text = coins.ToString();
    }

}
