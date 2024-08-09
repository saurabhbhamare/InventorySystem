using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopService : MonoSingletonGeneric<ShopService>
{
    //public ShopDescriptionPanel shopDescriptionPanel;
    [SerializeField] private ShopView shopView; 
    public BuyShopItemBox buyShopItemBox; 
    public ShopItem shopItem; 

    public void Start()
    {
        CreateShopSystem();
    }
    private void CreateShopSystem()
    {
        ShopModel shopModel = new ShopModel(shopItem);
        ShopController shopController = new ShopController(shopModel, shopView,shopItem);     
    }
}
