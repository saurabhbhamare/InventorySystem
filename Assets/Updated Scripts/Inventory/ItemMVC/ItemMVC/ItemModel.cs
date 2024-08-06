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
    public ItemModel()
    {
        itemQuantity = 1; 
    }
    public void SetItemController(ItemController itemController)
    {
        this.itemController = itemController; 
    }
    public ItemController GetItemController()
    {
        return this.itemController; 
    }
}
