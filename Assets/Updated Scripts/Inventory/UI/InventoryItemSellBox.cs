using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryItemSellBox : MonoBehaviour
{
    [SerializeField] private Button closeInventorySellBox;
    [SerializeField] private Image sellBoxItemImage;
    [SerializeField] private TextMeshProUGUI itemNameText;
    [SerializeField] private TextMeshProUGUI itemQuantityText;
    private ItemModel itemModel;
    private int itemSellQuantity;
    
    private void CloseInventoryItemSellBox()
    {
        this.gameObject.SetActive(false);
    }
    private void Start()
    {
        itemSellQuantity = 1; 
    }
    public void UpdateItemSellBoxInfo(Sprite itemSprite, int itemQuantity, string itemName) 
    {
        sellBoxItemImage.sprite = itemSprite;
        itemNameText.text = itemName;
        itemSellQuantity = 1;
        itemQuantityText.text = itemSellQuantity.ToString();
    }
    public void IncreaseItemSellQuantity()
    {
        if (itemSellQuantity >= itemModel.itemQuantity)
        {
            return; 
        }   
        itemSellQuantity++;
      
        itemQuantityText.text = itemSellQuantity.ToString();
        //sellQuantity = 
    }
    public void DecreaseItemSellQuantity()
    {
        if (itemSellQuantity <= 1)
        {
            Debug.Log("reached min quantity");
            return;
        }
        itemSellQuantity--;
        itemQuantityText.text = itemSellQuantity.ToString();
    }
    public void SetItemModelForSellBox(ItemModel itemModel)
    {
        this.itemModel = itemModel;
    }
    public void SellItem()
     {
        float decreasedItemWeight; 
        itemModel.itemQuantity -= itemSellQuantity;
        if(itemModel.itemQuantity == 0)
        {
            itemModel.GetItemController().itemView.gameObject.SetActive(false);
        }
        decreasedItemWeight = itemModel.itemWeight * itemSellQuantity;
        Debug.Log("weight which is going to be decreased is " + decreasedItemWeight);
        itemModel.GetItemController().itemView.itemQuantityText.text = itemModel.itemQuantity.ToString();
        this.gameObject.SetActive(false);
        InventoryService.Instance.GetInventoryView().GetInventoryController().inventoryModel.inventoryWeight -= decreasedItemWeight;
        float updatedItemWeight = InventoryService.Instance.GetInventoryView().GetInventoryController().inventoryModel.inventoryWeight;
        InventoryService.Instance.GetInventoryView().GetInventoryController().UpdateInventoryWeight(updatedItemWeight);
        UIService.Instance.playerCurrency.IncreaseCoinValue(itemSellQuantity * itemModel.itemSellingPrice);
    }
}
