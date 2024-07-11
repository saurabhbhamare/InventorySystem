using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class PlayerCurrency : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currencyText;
    private int totalCurrencyValue;
    private void Start()
    {
        totalCurrencyValue = 0; 
    }
    public void UpdateCurrencyText(int currency)
    {
        totalCurrencyValue += currency;
        currencyText.text = totalCurrencyValue.ToString(); 
    }
}
