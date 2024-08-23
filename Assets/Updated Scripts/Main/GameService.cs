using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameService : GenericMonoSingleton<GameService>
{
    public InventoryService inventoryService { get; private set; }
    public ShopService shopService { get; private set; }
    public UIService uiService;

    [SerializeField] private InventoryView inventoryView;
    [SerializeField] private ShopView shopView;
    [SerializeField] private ItemView itemView;
    [SerializeField] private ItemSOList itemSOList;
    [SerializeField] private BuyShopItemBox buyShopItemBox;
    [SerializeField] private ShopItem shopItem;

    private void Start()
    {
        inventoryService = new InventoryService(inventoryView, itemSOList);
        shopService = new ShopService(shopView,buyShopItemBox,shopItem);
    }
}
