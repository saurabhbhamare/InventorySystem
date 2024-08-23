using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class Currency : MonoBehaviour
{
    private int pCurrency=0;
    [SerializeField] private TextMeshProUGUI playerCurrencyText; 
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
    public void UpdateCurrencyAfterBuyingItems(int updatedCurrency)
    {
        pCurrency -= updatedCurrency;
        UpdatePlayerCurrency();
    }
    public void UpdatePlayerCurrency() => playerCurrencyText.text = pCurrency.ToString(); 
    public int GetPlayerCurrency() => pCurrency; 
}



