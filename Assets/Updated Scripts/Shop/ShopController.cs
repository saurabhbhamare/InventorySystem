using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController 
{
    public ShopView shopView;
    public ShopModel shopModel;

    public ShopController(ShopModel shopModel, ShopView shopView,ShopItem shopItem)
    {
        this.shopModel = shopModel;
        this.shopView = shopView;
        CreateShopItemSlots(shopItem);
        
    }
    public void CreateShopItemSlots(ShopItem shopItem)
    {
        for(int i = 0; i < 10; i++)
        {
            int randomItemID = Random.Range(0, 19);
            ShopItem shopItemSlot = GameObject.Instantiate<ShopItem>(shopItem);
            shopItemSlot.itemImage.sprite = InventoryService.Instance.GetItemSOList().InventoryItems[randomItemID].ItemSprite;
            shopItemSlot.itemID = randomItemID;
            
            shopModel.shopItemList.Add(shopItemSlot);
        }
    }
    public void BuyItemFromTheShop()
    {

    }

}
