using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SellItemBox : MonoBehaviour
{
    [SerializeField] private  Image sellItemImage;
    [SerializeField] private PlayerCurrency playerCurrency; 
    private int sellQuantity = 1 ;
    private ItemSlot itemSlot;
    [SerializeField] private TextMeshProUGUI sellingQuantityText;
    [SerializeField] private Inventory inventory;
    public void Start()
    {
        sellingQuantityText.text = sellQuantity.ToString(); 
    }
    public void ShowSellBox()
    {
        sellingQuantityText.text = sellQuantity.ToString();
        this.gameObject.SetActive(true);
    }
    public void SetItemSlotForSellBox(ItemSlot itemSlot)
    {
        this.itemSlot = itemSlot;
        sellItemImage.sprite = itemSlot.itemImage.sprite; 
    }
    public void IncreaseSellQuantity()
    {
        if(sellQuantity >= itemSlot.itemQuantity)
        {
            Debug.Log("reached max limit cant sell more");
            return;
        }
        sellQuantity++;
        sellingQuantityText.text = sellQuantity.ToString();     
    }
    public void DecreaseSellQuantity()
    {
        if (sellQuantity <= 1)
        {
            Debug.Log("reached least possibile value");

            return; 
        }

        sellQuantity--;
       
        sellingQuantityText.text = sellQuantity.ToString();
    }
    public void SellItems()
    {
         this.itemSlot.itemQuantity -= sellQuantity;
        this.itemSlot.UpdateItemSlotQuantity(itemSlot.itemQuantity);
         int totalCurrencyValue = itemSlot.itemSelllingPrice * sellQuantity;
        playerCurrency.UpdateCurrencyText(totalCurrencyValue);
        sellQuantity = 1;
        this.gameObject.SetActive(false);
        sellingQuantityText.text = sellQuantity.ToString();
    }
}
