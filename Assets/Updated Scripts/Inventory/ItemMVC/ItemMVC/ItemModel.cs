using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemModel
{
    public int itemQuantity;
    public string itemName;
    public string itemDescription;
    public ItemController itemController;
    public float itemWeight;
    public int itemBuyingPrice;
    public int itemSellingPrice;
    public bool isDescriptionPanelActive = false;
    private bool isItemSellBoxPanelActive = false;
    public int itemID;

    public void SetItemController(ItemController itemController)
    {
        this.itemController = itemController; 
    }
    public ItemController GetItemController()
    {
        return this.itemController; 
    }
    public bool GetDescriptionPanelVisibilityStatus()
    {
        return isDescriptionPanelActive;
    }
}
