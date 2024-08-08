using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour,IPointerClickHandler
{
    public int itemID;
    public string itemName;
    //public ItemSO itemSO;
    public Image itemImage;
   // public List<ShopItem> shopItemList;

    private void Start()
    {
       // itemImage.sprite = InventoryService.Instance.GetInventoryView().inventoryController.inventoryModel.itemSOList.InventoryItems[itemID].ItemSprite;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
       if(eventData.button == PointerEventData.InputButton.Right)
        {

        }
    }

}

