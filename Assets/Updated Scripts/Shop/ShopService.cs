using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopService : MonoBehaviour
{
    //public ShopDescriptionPanel shopDescriptionPanel;
    [SerializeField] private ShopView shopView; 
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
