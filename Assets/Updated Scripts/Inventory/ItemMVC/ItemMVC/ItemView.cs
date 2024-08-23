using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemView : MonoBehaviour,IPointerClickHandler
{
     public  TextMeshProUGUI itemQuantityText;
     public Image itemImage;
     public ItemController itemController;
    [SerializeField] private InventoryItemSellBox inventoryItemSellBox; 
    private void Awake()
    {
        itemQuantityText.text = 1.ToString();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            itemController.HandleInventoryItemLeftClick();
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            itemController.HandleInventoryItemRightClick();
        }
    }
    public ItemController GetItemController() => itemController;
    public void SetItemController(ItemController itemController)
    {
        this.itemController = itemController;
    }
}

 