using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryItemSellBox : MonoBehaviour
{
    public Button closeInventorySellBox;
    public Image sellBoxItemImage;
    public TextMeshProUGUI itemQuantityText;
    public ItemModel itemModel;
    public int sellQuantity;
    
    public void CloseInventoryItemSellBox()
    {
        this.gameObject.SetActive(false);
    }
    public void UpdateItemSellBoxInfo(Sprite itemSprite, int itemQuantity)
    {
        sellBoxItemImage.sprite = itemSprite;
        itemQuantityText.text = itemQuantity.ToString();
    }
    public void IncreaseItemSellQuantity()
    {
      //  if( >)
        itemModel.itemQuantity++;
      
        itemQuantityText.text = itemModel.itemQuantity.ToString();
        //sellQuantity = 
    }
    public void DecreaseItemSellQuantity()
    {
        if (itemModel.itemQuantity <= 1)
        {
            Debug.Log("reached min quantity");
            return;
        }
        itemModel.itemQuantity--;
        itemQuantityText.text = itemModel.itemQuantity.ToString();
    }
    public void SetItemModelForSellBox(ItemModel itemModel)
    {
        this.itemModel = itemModel;
    }
    public void SellItem()
    {
      //  itemModel.itemQuantity -=
    }
}
