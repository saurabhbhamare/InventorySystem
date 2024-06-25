using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject inventory;
    [SerializeField] private GameObject shop;
//    [SerializeField] private GameObject info;
   // [SerializeField] private GameObject quit;
    bool inventoryRunning = false;
//    bool shopRunning = false;
    public void DisplayInventory()
    {
     //   inventoryRunning = true; 
        if(inventoryRunning)
        {
            inventory.SetActive(false);
            inventoryRunning = false;
        }
        else
        {
            inventory.SetActive(true);
            inventoryRunning = true;
          //  shopRunning = false;
        }
    }
    //public void DisplayShop()
    //{
    //    shop.SetActive(true);
    //    inventory.SetActive(false);

    //}

}
