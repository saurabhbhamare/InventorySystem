using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject inventory;
    [SerializeField] private GameObject shop;
    bool inventoryRunning = false;
    bool shopRunning = false;
    private void Start()
    {
        inventory.SetActive(false);
    }
    public void DisplayInventory()
    {
        inventoryRunning = !inventoryRunning;
        inventory.SetActive(inventoryRunning);
        shopRunning = false;
        shop.SetActive(false);
        UIService.Instance.UpdateCurrencyPanelVisibility(inventoryRunning);
    }
    public void DisplayShop()
    {
        shopRunning = !shopRunning;
        shop.SetActive(shopRunning);
        inventoryRunning = false;
        inventory.SetActive(false);
        UIService.Instance.UpdateCurrencyPanelVisibility(shopRunning);
    }
}
