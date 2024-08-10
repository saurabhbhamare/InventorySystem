using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class Currency : MonoBehaviour
{
    public int pCurrency;
    public TextMeshProUGUI playerCurrencyText; 
    
    public void IncreaseCoinValue(int currency)
    {
        pCurrency += currency;
        UpdatePlayerCurrency();
    }
    public void DecreaseCoinValue(int currency)
    {
        pCurrency -= currency;
        UpdatePlayerCurrency();
    }
    public void UpdatePlayerCurrency()
    {
        playerCurrencyText.text = pCurrency.ToString();
    }
}
