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
    public Image itemImage;
    public string itemDescription;
    public int itemSelllingPrice; 

    [SerializeField] private TextMeshProUGUI itemDescriptionText;
    [SerializeField] private GameObject descriptionPanel;
    [SerializeField] private TextMeshProUGUI itemQuantityText;
    [SerializeField] private SellItemBox sellItemBox; 
    private void Awake()
    {
        itemID = 0; 
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(this.gameObject.name+ " Pointer clicked");
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            ShowDescriptionPanel();
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        
        {
            if (sellItemBox.gameObject.activeSelf)
            {
                sellItemBox.gameObject.SetActive(false);
            }
            else
            {
                sellItemBox.SetItemSlotForSellBox(this);
                sellItemBox.gameObject.SetActive(true);
            }
        }
    }
    public void UpdateItemSlotQuantity(int itemQuantity)
    {
        if(this.itemQuantity < 1)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }

        itemQuantityText.text = itemQuantity.ToString();
    }
    public void SetItemDescription(string itemDescription)
    {
        this.itemDescriptionText.text = itemDescription;
    }
    public void ShowDescriptionPanel()
    {
        descriptionPanel.SetActive(true);
        descriptionPanel.GetComponent<DescriptionPanel>().UpdateDescriptionBoxInfo(this);
    }

}


