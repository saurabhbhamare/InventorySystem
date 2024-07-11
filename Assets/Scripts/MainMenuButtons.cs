using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject inventory;
    [SerializeField] private GameObject shop;
  //  [SerializeField] private GameObject info;
  //  [SerializeField] private GameObject quit;
    bool inventoryRunning = false;
    bool shopRunning = false;
    private void Start()
    {
        inventory.SetActive(false);
     //   shop.SetActive(false);
     //   info.SetActive(false);
     //   quit.SetActive(false);

    }
    public void DisplayInventory()
    {
        inventoryRunning = !inventoryRunning;
        inventory.SetActive(inventoryRunning);
        shopRunning = false;
        shop.SetActive(false);
    }
    public void DisplayShop()
    {
        shopRunning = !shopRunning;
        shop.SetActive(shopRunning);
        inventoryRunning = false;
        inventory.SetActive(false);
    }
}
