using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class ItemDescriptionPanelView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private Image itemImage;
    [SerializeField] private TextMeshProUGUI itemDescriptiontext;
    public void UpdateItemDescriptionPanelInfo(string itemName, Sprite itemSprite, string itemDescription)
    {
        this.itemName.text = itemName;
        this.itemImage.sprite = itemSprite;
        this.itemDescriptiontext.text = itemDescription;
            
    }
}
