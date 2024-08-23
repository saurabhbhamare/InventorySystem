using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopService
{
    private ShopView shopView;
    private BuyShopItemBox buyShopItemBox;
    private ShopItem shopItem;
    public ShopService(ShopView showView, BuyShopItemBox buyShopItemBox,ShopItem shopItem)
    {
        this.shopView = showView;
        this.buyShopItemBox = buyShopItemBox;
        this.shopItem = shopItem;
        CreateShopSystem();
    }
    private void CreateShopSystem()
    {
        ShopModel shopModel = new ShopModel(shopItem);
        ShopController shopController = new ShopController(shopModel, shopView,shopItem);     
    }
}
