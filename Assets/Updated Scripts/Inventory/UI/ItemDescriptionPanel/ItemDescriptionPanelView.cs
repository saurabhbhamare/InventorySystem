using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class ItemDescriptionPanelView : MonoBehaviour
{
    public TextMeshProUGUI itemName;
    public Image itemImage;
    public TextMeshProUGUI itemDescriptiontext;
   // public ItemView itemView;

    public void ShowItemDescriptionPanel()
    {
        this.gameObject.SetActive(true);
    }
    public void HideItemDescriptionPanel()
    {
        this.gameObject.SetActive(false);
    }
}
