using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController
{
    public ItemView itemView;
    private ItemModel itemModel;

    public ItemController(ItemView itemView, ItemModel itemModel)
    {
        this.itemModel = itemModel;
        this.itemView = itemView;
    }
    public void UpdateItemSlotUI()
    {
        itemView.itemQuantityText.text = itemModel.itemQuantity.ToString();
    }
    public ItemModel GetItemModel()
    {
        return itemModel;
    }
    public void HandleInventoryItemLeftClick()
    {
        itemModel.isDescriptionPanelActive = !itemModel.isDescriptionPanelActive;

        UIService.Instance.itemDescriptionPanel.gameObject.SetActive(itemModel.isDescriptionPanelActive);
        UIService.Instance.itemDescriptionPanel.UpdateItemDescriptionPanelInfo(itemModel.itemName,
            itemView.itemImage.sprite, itemModel.itemDescription);
    }
    public void HandleInventoryItemRightClick()
    {
        UIService.Instance.sellItemBox.gameObject.SetActive(true);
        UIService.Instance.sellItemBox.UpdateItemSellBoxInfo(itemView.itemImage.sprite, itemModel.itemQuantity, itemModel.itemName);
        UIService.Instance.sellItemBox.SetItemModelForSellBox(itemModel);
    }
}
