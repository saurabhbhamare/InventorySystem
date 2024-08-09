using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController 
{
    public ShopView shopView;
    public ShopModel shopModel;
    HashSet<int> uniqueNumbers = new HashSet<int>();
    public ShopController(ShopModel shopModel, ShopView shopView,ShopItem shopItem)
    {
        this.shopModel = shopModel;
        this.shopView = shopView;
        CreateShopItemSlots(shopItem);
    }
    public void CreateShopItemSlots(ShopItem shopItem)
    {
        for (int i = 0; i < 10; i++)
        {
            int randomItemID;
            do
            {
                randomItemID = Random.Range(0, 19);
            } while (uniqueNumbers.Contains(randomItemID));
          //  int randomItemID = Random.Range(0, 19);
           ShopItem shopItemSlot = GameObject.Instantiate<ShopItem>(shopItem);
            shopItemSlot.gameObject.transform.SetParent(shopView.contentArea);
          // ShopItem shopItemSlot = Instantiate(shopItem, shopView.contentArea); 
           shopItemSlot.itemImage.sprite = InventoryService.Instance.GetItemSOList().InventoryItems[randomItemID].ItemSprite;
           shopItemSlot.itemID = randomItemID;
            
          shopModel.shopItemList.Add(shopItemSlot);
        }
    }
    public void BuyItemFromTheShop()
    {

    }

}
