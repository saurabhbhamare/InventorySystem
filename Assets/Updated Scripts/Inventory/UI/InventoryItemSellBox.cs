using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryItemSellBox : MonoBehaviour
{
    public Button closeInventorySellBox;
    public Image sellBoxItemImage;
    public TextMeshProUGUI itemNameText;
    public TextMeshProUGUI itemQuantityText;
    public ItemModel itemModel;
    public int itemSellQuantity;
    
    public void CloseInventoryItemSellBox()
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
      //   = itemModel.itemQuantity;
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
        itemModel.itemQuantity -= itemSellQuantity;
        itemModel.GetItemController().itemView.itemQuantityText.text = itemModel.itemQuantity.ToString();
    }
}
