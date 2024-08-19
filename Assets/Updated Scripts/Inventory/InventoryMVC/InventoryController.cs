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
    public void AddItemToTheInventory(ItemView itemView, SpawnObjectType spawnObjectType, int itemIDForShop, int itemBuyQuantity)
    {
        int itemID=itemIDForShop;

        if (spawnObjectType == SpawnObjectType.INVENTORY)
        {
            int pickRandomItem = GenerateRandomItem();
             itemID = inventoryModel.GetItemSOList().InventoryItems[pickRandomItem].ItemID;
        }
        if (inventoryModel.itemControllerList.TryGetValue(itemID, out ItemController existingSlot))
        {
            existingSlot.itemView.gameObject.SetActive(true);
            if(spawnObjectType == SpawnObjectType.SHOP)
            {
               existingSlot.GetItemModel().itemQuantity += itemBuyQuantity;
               this.inventoryModel.inventoryWeight += inventoryModel.itemSOList.InventoryItems[itemIDForShop].ItemWeight* itemBuyQuantity;
             UpdateInventoryWeight(inventoryModel.inventoryWeight);
            }
            else  if(spawnObjectType == SpawnObjectType.INVENTORY)
            {
                existingSlot.GetItemModel().itemQuantity++;
                this.inventoryModel.inventoryWeight += inventoryModel.itemSOList.InventoryItems[itemID].ItemWeight;
                UpdateInventoryWeight(inventoryModel.inventoryWeight);
            }
            existingSlot.itemView.itemQuantityText.text = existingSlot.GetItemModel().itemQuantity.ToString();
        }
        else
        {
            ItemView itemSlot = GameObject.Instantiate<ItemView>(itemView);
            ItemModel itemModel = new ItemModel();
            ItemController itemController = new ItemController(itemSlot, itemModel);
            itemModel.SetItemController(itemController);
            itemSlot.SetItemController(itemController);
            if (spawnObjectType == SpawnObjectType.SHOP)
            {
               itemModel.itemQuantity += itemBuyQuantity;
                itemSlot.itemQuantityText.text = itemModel.itemQuantity.ToString();
            }
            else
            {
                itemModel.itemQuantity++;
                Debug.Log("running else statement as well");
            }
           
            itemModel.itemName = inventoryModel.GetItemSOList().InventoryItems[itemID].ItemName;
            itemModel.itemWeight = inventoryModel.GetItemSOList().InventoryItems[itemID].ItemWeight;
            itemSlot.itemImage.sprite = inventoryModel.GetItemSOList().InventoryItems[itemID].ItemSprite;
            itemModel.itemDescription = inventoryModel.GetItemSOList().InventoryItems[itemID].ItemDescription;
            itemModel.itemBuyingPrice = inventoryModel.GetItemSOList().InventoryItems[itemID].ItemBuyingPrice;
            itemModel.itemSellingPrice = inventoryModel.GetItemSOList().InventoryItems[itemID].ItemSellingPrice;
            itemModel.itemID = itemID;
            inventoryModel.itemControllerList.Add(itemID, itemController);

            itemSlot.transform.SetParent(inventoryView.parentTransform.transform, false);
            itemSlot.transform.position = inventoryView.parentTransform.transform.position;
            if (spawnObjectType == SpawnObjectType.SHOP)
            {
                this.inventoryModel.inventoryWeight += itemModel.itemWeight * itemBuyQuantity;
            }
            else if(spawnObjectType == SpawnObjectType.INVENTORY)
            {
                this.inventoryModel.inventoryWeight += itemModel.itemWeight;
            }
            UpdateInventoryWeight(inventoryModel.inventoryWeight);
        }
    }
    public void AddShopItems()
    {
        int itemId  = GenerateRandomItem();
        ItemView itemView = new ItemView();
    }
    private int GenerateRandomItem()
    {
        int randomNumber = Random.Range(0, inventoryModel.GetItemSOList().InventoryItems.Count);
        return randomNumber;
    }
    public void UpdateInventoryWeight(float itemWeight)
    {
        inventoryView.GetInventoryWeightTextGUI().text = "Weight : "+itemWeight.ToString();
    }
}