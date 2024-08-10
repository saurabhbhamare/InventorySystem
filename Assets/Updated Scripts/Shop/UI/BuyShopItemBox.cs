using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class BuyShopItemBox : MonoBehaviour
{
    public Image buyItemImage;
    public int itemBuyQuantity;
    public TextMeshProUGUI itemBuyQuantityText;
    public TextMeshProUGUI itemNameText;
    ShopItem shopItem;


    private void Start()
    {
        itemBuyQuantity = 1;
        itemBuyQuantityText.text = itemBuyQuantity.ToString();

    }
    public void SetShopItem(ShopItem shopItem)
    {
        this.shopItem = shopItem;
    }
    public void IncreaseItemBuyQuantity()
    {
      
        itemBuyQuantity++;

        itemBuyQuantityText.text = itemBuyQuantity.ToString();
        //sellQuantity =

    }
    public void DecreaseItemBuyQuantity()
    {
        if (itemBuyQuantity <= 1)
        {
            Debug.Log("reached min quantity");
            return;
        }
        itemBuyQuantity--;
        itemBuyQuantityText.text = itemBuyQuantity.ToString();
    }
    public void CloseShopItemBuyBox()
    {
        this.gameObject.SetActive(false);
    }
    public void BuyItemButton()
    {
        shopItem.itemQuantity -= itemBuyQuantity;
        // itemBuyQuantityText.text = shopItem.itemQuantity.ToString();
        shopItem.itemQuantityText.text = shopItem.itemQuantity.ToString();
        this.gameObject.SetActive(false);
    }

    
}
