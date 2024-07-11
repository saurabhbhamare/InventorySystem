using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DescriptionPanel : MonoBehaviour
{
    [SerializeField] private Image descriptionImage;
    [SerializeField] private TextMeshProUGUI itemDescription;
    [SerializeField] private TextMeshProUGUI itemName; 
   // private ItemSlot itemSlot; 
  public  void UpdateDescriptionBoxInfo(ItemSlot itemSlot)
    {
        Debug.Log(itemSlot.itemName);
         this.descriptionImage.sprite = itemSlot.itemImage.sprite;
        this.itemName.text = itemSlot.itemName;
        this.itemDescription.text = itemSlot.itemDescription;
    }
}
