using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopModel 
{
     public  List<ShopItem> shopItemList;
     private ShopItem shopItem; 
    public ShopModel(ShopItem shopItem)
    {
        this.shopItem = shopItem;
        shopItemList = new List<ShopItem>();
    }

    //public List<ShopItem> GetShopItemList()
    //{
    //    return shopItemList;
    //}
    public ShopItem GetShopItem()
    {
        return shopItem;
    }

}
