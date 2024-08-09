using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class UIService : MonoSingletonGeneric<UIService>
{
    public  ItemDescriptionPanelView itemDescriptionPanel;
    public InventoryItemSellBox sellItemBox;
    public Currency playerCurrency;
    bool playerCurrencyVisibilityStatus;
    public void UpdateCurrencyPanelVisibility(bool currencyVisibility)
    {
        playerCurrency.gameObject.SetActive(currencyVisibility);
    }
}
