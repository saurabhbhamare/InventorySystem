using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DescriptionPanel : MonoBehaviour
{
    [SerializeField] private Image descriptionImage;
    [SerializeField] private TextMeshProUGUI description;
    private ItemSlot itemSlot; 
  public  void UpdateDescriptionBoxInfo(ItemSlot itemSlot)
    {
        this.itemSlot = itemSlot; 
        descriptionImage.sprite = this.itemSlot.itemImage.sprite;
      //  description.text= itemSO.ItemDescription;
    }
}
