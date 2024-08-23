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
        itemQuantity = 999;
        itemQuantityText.text = itemQuantity.ToString();
        buyingPriceText.text = " GC "+ GameService.Instance.inventoryService.GetInventoryView().inventoryController.inventoryModel.itemSOList.InventoryItems[itemID].ItemBuyingPrice.ToString();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
       if(eventData.button == PointerEventData.InputButton.Right)
        {
            GameService.Instance.uiService.buyShopItemBox.gameObject.SetActive(true);
            GameService.Instance.uiService.buyShopItemBox.GetBuyItemImage().sprite = GameService.Instance.inventoryService.GetInventoryView().inventoryController.inventoryModel.itemSOList.InventoryItems[itemID].ItemSprite;
            GameService.Instance.uiService.buyShopItemBox.GetItemNameText().text = GameService.Instance.inventoryService.GetInventoryView().inventoryController.inventoryModel.itemSOList.InventoryItems[itemID].ItemName.ToString();
            GameService.Instance.uiService.buyShopItemBox.SetShopItem(this);
        }
    }
    public int GetItemQuantity() => itemQuantity;
}

