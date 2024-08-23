using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class BuyShopItemBox : MonoBehaviour
{
    [SerializeField] private Image buyItemImage;  // public changed to serializefield private
    private int itemBuyQuantity;                            //changed public to private
    [SerializeField] private TextMeshProUGUI itemBuyQuantityText;
    [SerializeField] private TextMeshProUGUI itemNameText;
    private ShopItem shopItem;
    [SerializeField] private ItemView itemView;    //added after updating the controller
    [SerializeField] private Currency currency;
    private void Start()
    {
        itemBuyQuantity = 1;
        itemBuyQuantityText.text = itemBuyQuantity.ToString();
    }
    public Image GetBuyItemImage()
    {
        return buyItemImage;
    }
    public TextMeshProUGUI GetItemNameText()
    {
        return itemNameText;
    }
    public void SetShopItem(ShopItem shopItem)
    {
        this.shopItem = shopItem;
    }
    public void IncreaseItemBuyQuantity()
    {
        itemBuyQuantity++;
        itemBuyQuantityText.text = itemBuyQuantity.ToString();
    }
    public void DecreaseItemBuyQuantity()
    {
        if (itemBuyQuantity <= 1)
        {
            Debug.Log("reached min quantity");
            return;
        }
        itemBuyQuantity--;
        itemBuyQuantityText.text = itemBuyQuantity.ToString();
    }
    public void CloseShopItemBuyBox()
    {
        itemBuyQuantity = 1;
        itemBuyQuantityText.text = itemBuyQuantity.ToString();
        this.gameObject.SetActive(false);
    }
        public void BuyItemButton()
        {
        int selectedItemsPrice = GameService.Instance.inventoryService.GetInventoryView().GetInventoryController().inventoryModel.GetItemSOList().InventoryItems[shopItem.itemID].ItemBuyingPrice * itemBuyQuantity;
      if (currency.GetPlayerCurrency() >= GameService.Instance.inventoryService.GetInventoryView().GetInventoryController().inventoryModel.GetItemSOList().InventoryItems[shopItem.itemID].ItemBuyingPrice*itemBuyQuantity)
        {
            shopItem.itemQuantity -= itemBuyQuantity;
            int itemWeight = (int)GameService.Instance.inventoryService.GetInventoryView().GetInventoryController().inventoryModel.GetItemSOList().InventoryItems[shopItem.itemID].ItemWeight * itemBuyQuantity;
            shopItem.itemQuantityText.text = shopItem.itemQuantity.ToString();
            GameService.Instance.inventoryService.GetInventoryView().GetInventoryController().AddItemToTheInventory(itemView, SpawnObjectType.SHOP, shopItem.itemID, itemBuyQuantity);
            currency.UpdateCurrencyAfterBuyingItems(selectedItemsPrice);
            this.gameObject.SetActive(false);
            return;
        }
        Debug.Log("You don�t have enough money.");
        }
}
