using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro; 
public class ShopItem : MonoBehaviour,IPointerClickHandler
{

    public int itemID;
    public string itemName;
    public int itemQuantity;
    public Image itemImage;
    public List<ShopItem> shopItemList;
    public int buyingPrice;
    public TextMeshProUGUI buyingPriceText; 
    public TextMeshProUGUI itemQuantityText; 

    private void Start()
    {
       // itemImage.sprite = InventoryService.Instance.GetInventoryView().inventoryController.inventoryModel.itemSOList.InventoryItems[itemID].ItemSprite;
        itemQuantity = 99;
        itemQuantityText.text = itemQuantity.ToString();
        buyingPriceText.text = InventoryService.Instance.GetInventoryView().inventoryController.inventoryModel.itemSOList.InventoryItems[itemID].ItemSellingPrice.ToString();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
       if(eventData.button == PointerEventData.InputButton.Right)
        {
            ShopService.Instance.buyShopItemBox.gameObject.SetActive(true);
            ShopService.Instance.buyShopItemBox.buyItemImage.sprite = InventoryService.Instance.GetInventoryView().inventoryController.inventoryModel.itemSOList.InventoryItems[itemID].ItemSprite;
            ShopService.Instance.buyShopItemBox.itemNameText.text = InventoryService.Instance.GetInventoryView().inventoryController.inventoryModel.itemSOList.InventoryItems[itemID].ItemName.ToString();
        }
    }

}

