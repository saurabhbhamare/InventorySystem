using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InventoryService 
{
    private InventoryView inventoryView;
    private ItemSOList itemSOList;
    public InventoryService(InventoryView inventoryView , ItemSOList itemSOList)
    {
        this.inventoryView = inventoryView;
        this.itemSOList = itemSOList;
        CreateInventory();
    }
    private void CreateInventory()
    {
        InventoryModel inventoryModel = new InventoryModel(itemSOList);
        InventoryController inventoryController = new InventoryController(inventoryModel, inventoryView,itemSOList); 
    }
    public InventoryView GetInventoryView()
    {
        return inventoryView;
    }
    public ItemSOList GetItemSOList()
    {
        return itemSOList;
    }

}
