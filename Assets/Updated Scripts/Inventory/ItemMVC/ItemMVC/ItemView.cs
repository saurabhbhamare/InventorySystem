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
     private bool isDescriptionPanelActive = false;
     private bool isItemSellBoxPanelActive = false;
    private void Awake()
    {
        itemQuantityText.text = 1.ToString();
    }
    private void Start()
    {
        //EventService.Instance.OnLeftClickInventoryItem += HandleLeftClickOnItem;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            //EventService.Instance.OnLeftClickInventoryItem?.Invoke();
            HandleLeftClickOnItem();
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            HandleRightClickOnItem();
        }
    }
    public ItemController GetItemController()
    {
        return itemController;
    }
    public void HandleLeftClickOnItem()
    {
        isDescriptionPanelActive = !isDescriptionPanelActive;
        UIService.Instance.itemDescriptionPanel.gameObject.SetActive(isDescriptionPanelActive);
        UIService.Instance.itemDescriptionPanel.UpdateItemDescriptionPanelInfo(this.GetItemController().GetItemModel().itemName,
            itemImage.sprite, this.GetItemController().GetItemModel().itemDescription);
        //UIService.Instance.itemDescriptionPanel.
    }
    public void HandleRightClickOnItem()
    {
        UIService.Instance.sellItemBox.gameObject.SetActive(true);
        UIService.Instance.sellItemBox.UpdateItemSellBoxInfo(itemImage.sprite,GetItemController().GetItemModel().itemQuantity, GetItemController().GetItemModel().itemName);
        UIService.Instance.sellItemBox.SetItemModelForSellBox(this.GetItemController().GetItemModel());
    }
    public void SetItemController(ItemController itemController)
    {
        this.itemController = itemController;
    }
}
