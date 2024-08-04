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
    public void SetItemController(ItemController itemController)
    {
        this.itemController = itemController;
    }
}
