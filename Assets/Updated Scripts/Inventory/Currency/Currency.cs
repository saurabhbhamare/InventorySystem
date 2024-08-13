using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class Currency : MonoBehaviour
{
    private int pCurrency;
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
    private void UpdatePlayerCurrency()
    {
        playerCurrencyText.text = pCurrency.ToString();
    }
}



