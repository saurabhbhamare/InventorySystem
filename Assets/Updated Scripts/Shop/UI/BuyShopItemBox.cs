using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class BuyShopItemBox : MonoBehaviour
{
    public Image buyItemImage;
    public int  itemBuyQuantity;
    public TextMeshProUGUI itemBuyQuantityText;
    public TextMeshProUGUI itemNameText; 


    private void Start()
    {
        itemBuyQuantity = 1;
        itemBuyQuantityText.text = itemBuyQuantity.ToString();

    }
    public void IncreaseItemBuyQuantity()
    {
        //if (itemBuyQuantity >= ShopService.Instance.shopModel.shopItemList.itemQuantity)
        //{
        //    return;
        //}
        //itemBuyQuantity++;

        //itemBuyQuantity.text = itemBuyQuantity.ToString();
        //sellQuantity =
    }
    public void DecreaseItemBuyQuantity()
    {
        //if (itemBuyQuantity <= 1)
        //{
        //    Debug.Log("reached min quantity");
        //    return;
        //}
        //itemSellQuantity--;
        //itemQuantityText.text = itemSellQuantity.ToString();
    }
    public void CloseShopItemBuyBox()
    {
        this.gameObject.SetActive(false);
    }
}
