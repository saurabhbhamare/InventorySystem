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
            existingSlot.itemView.gameObject.SetActive(true);
            existingSlot.GetItemModel().itemQuantity++;
            existingSlot.itemView.itemQuantityText.text = existingSlot.GetItemModel().itemQuantity.ToString();
            this.inventoryModel.inventoryWeight += inventoryModel.itemSOList.InventoryItems[itemID].ItemWeight;
            UpdateInventoryWeight(inventoryModel.inventoryWeight);
        }
        else
        {
            // Create a new item slot
            ItemView itemSlot = GameObject.Instantiate<ItemView>(itemView);
            ItemModel itemModel = new ItemModel();
            ItemController itemController = new ItemController(itemSlot, itemModel);
            itemModel.SetItemController(itemController);
            itemSlot.SetItemController(itemController);
            itemModel.itemName = inventoryModel.GetItemSOList().InventoryItems[pickRandomItem].ItemName;
            itemSlot.itemImage.sprite = inventoryModel.GetItemSOList().InventoryItems[pickRandomItem].ItemSprite;
          //  itemSlot.GetItemController().GetItemModel().itemName = inventoryModel.GetItemSOList().InventoryItems[pickRandomItem].ItemName;
         //   itemSlot.GetItemController().GetItemModel().itemDescription = inventoryModel.GetItemSOList().InventoryItems[pickRandomItem].ItemDescription;
            itemModel.itemDescription = inventoryModel.GetItemSOList().InventoryItems[pickRandomItem].ItemDescription;
            inventoryModel.itemControllerList.Add(itemID, itemController);

            itemSlot.transform.SetParent(inventoryView.parentTransform.transform, false);
            itemSlot.transform.position = inventoryView.parentTransform.transform.position;
            this.inventoryModel.inventoryWeight += inventoryModel.itemSOList.InventoryItems[itemID].ItemWeight;
            UpdateInventoryWeight(inventoryModel.inventoryWeight);
        }
    }
    private void RemoveItemFromTheInventory(ItemController itemController)
    {
        
    }
    private int GenerateRandomItem()
    {
        int randomNumber = Random.Range(0, inventoryModel.GetItemSOList().InventoryItems.Count);
        return randomNumber;
    }
    public void UpdateInventoryWeight(float itemWeight)
    {
        inventoryView.GetInventoryWeightTextGUI().text = itemWeight.ToString();
    }
    public void UpdateInventoryCurreny()
    {


    }

}