using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text coinsUI;
    
    [SerializeField]
    private int keys = 0;
    [SerializeField]
    private int coins = 0;

    public void PickUpCoin()
    {
        coins++;
        coinsUI.text = $"Coins: {coins}";
    }

    public void PickUpKey()
    {
        keys++;
    }

    public int GetKeys()
    {
        return keys;
    }
}
