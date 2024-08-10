using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryModel
{
    public float inventoryWeight;
    public float maxInventoryWeight;
    private InventoryController inventoryController;
    public Dictionary<int, ItemController> itemControllerList;
    public ItemSOList itemSOList;
    public InventoryModel(ItemSOList itemSOList)
    {
        this.itemSOList = itemSOList;
        itemControllerList = new Dictionary<int, ItemController>();
    }
    public void SetInventoryController(InventoryController inventoryController)
    {
        this.inventoryController = inventoryController;
    }
    public ItemSOList GetItemSOList()
    {
        return itemSOList;
    }
    
}
