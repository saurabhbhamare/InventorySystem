using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InventoryController 
{
    public InventoryModel inventoryModel { get; private set; }
    public InventoryView inventoryView { get; private set; }
    public InventoryController(InventoryModel inventoryModel , InventoryView inventoryView,ItemSOList itemSOList)
    {
        this.inventoryModel = inventoryModel;
        this.inventoryView = inventoryView;
        this.inventoryView.SetInventoryController(this);
    }
    public void AddItemToTheInventory(ItemView itemView)
    {
        int pickRandomItem = GenerateRandomItem();
        int itemID = inventoryModel.GetItemSOList().InventoryItems[pickRandomItem].ItemID;

        if (inventoryModel.itemControllerList.TryGetValue(itemID, out var existingSlot))
        {
            existingSlot.GetItemModel().itemQuantity++;
            existingSlot.itemView.itemQuantityText.text = existingSlot.GetItemModel().itemQuantity.ToString();
        }
        else
        {
            // Create a new item slot
            ItemView itemSlot = GameObject.Instantiate<ItemView>(itemView);
            itemSlot.itemImage.sprite = inventoryModel.GetItemSOList().InventoryItems[pickRandomItem].ItemSprite;

            ItemModel itemModel = new ItemModel();
            ItemController itemController = new ItemController(itemSlot, itemModel);
            inventoryModel.itemControllerList.Add(itemID, itemController);

            itemSlot.transform.SetParent(inventoryView.parentTransform.transform, false);
            itemSlot.transform.position = inventoryView.parentTransform.transform.position;
        }
    }
    private void RemoveItemFromTheInventory()
    {

    }
    public int GenerateRandomItem()
    {
        int randomNumber = Random.Range(0, inventoryModel.GetItemSOList().InventoryItems.Count);
        return randomNumber;
    }
}