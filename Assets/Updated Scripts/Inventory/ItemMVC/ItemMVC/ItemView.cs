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
   //  private bool isDescriptionPanelActive = false;
   //  private bool isItemSellBoxPanelActive = false;
    [SerializeField] private InventoryItemSellBox inventoryItemSellBox; // created a new inv sell box 
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
        //itemController.GetItemModel().isDescriptionPanelActive = !itemController.GetItemModel().isDescriptionPanelActive;

        //UIService.Instance.itemDescriptionPanel.gameObject.SetActive(itemController.GetItemModel().isDescriptionPanelActive);
        //UIService.Instance.itemDescriptionPanel.UpdateItemDescriptionPanelInfo(this.GetItemController().GetItemModel().itemName,
        //    itemImage.sprite, this.GetItemController().GetItemModel().itemDescription);

        itemController.HandleInventoryItemLeftClick();
    }
    public void HandleRightClickOnItem()
    {
        UIService.Instance.sellItemBox.gameObject.SetActive(true);
        UIService.Instance.sellItemBox.UpdateItemSellBoxInfo(itemImage.sprite, GetItemController().GetItemModel().itemQuantity, GetItemController().GetItemModel().itemName);
        UIService.Instance.sellItemBox.SetItemModelForSellBox(this.GetItemController().GetItemModel());
    //    itemController.HandleInventoryItemLeftClick();
    }
    public void SetItemController(ItemController itemController)
    {
        this.itemController = itemController;
    }
}
