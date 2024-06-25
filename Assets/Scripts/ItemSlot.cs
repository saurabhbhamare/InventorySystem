using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
public class ItemSlot: MonoBehaviour,IPointerClickHandler
{
 
    public int itemID;
    public string itemName;
    public int itemQuantity;
    public  Image itemImage;
    public TextMeshProUGUI quantityText;
    [SerializeField] private GameObject descriptionPanel;
   // [SerializeField] private DescriptionPanel descriptionPanelObject;
    private void Awake()
    {
        itemID = 0; 
      //  item = transform.parent.gameObject;  
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        ShowDescriptionPanel();
        Debug.Log("running onpointer click");
    }

    public void SetItemInfo(Sprite itemSprite, string itemName)
    {
      //  this.itemImage.sprite = itemSprite;+
      //  this.itemName = itemName; 

    }
    public void ShowDescriptionPanel()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<DescriptionPanel>().UpdateDescriptionBoxInfo(this);       
    }
    
}


