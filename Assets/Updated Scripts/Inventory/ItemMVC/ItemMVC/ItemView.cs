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
            EventService.Instance.OnLeftClickInventoryItem?.Invoke();
        }
    }
    public ItemController GetItemController()
    {
        return itemController;
    }
    public void HandleLeftClickOnItem()
    {
        UIService.Instance.itemDescriptionPanel.gameObject.SetActive(true);
        //UIService.Instance.itemDescriptionPanel.
    }
}
