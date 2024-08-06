using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryService : MonoSingletonGeneric<InventoryService>
{
    [SerializeField] private InventoryView inventoryView;
    [SerializeField] private ItemSOList itemSOList;

    private void Start()
    {
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
}
