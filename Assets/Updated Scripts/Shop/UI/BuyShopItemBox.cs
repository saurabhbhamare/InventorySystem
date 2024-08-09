using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyShopItemBox : MonoBehaviour
{
   public int  itemBuyQuantity;

    public void IncreaseItemSellQuantity()
    {
        //if (itemBuyQuantity >= ShopService.Instance.shopModel.shopItemList.itemQuantity)
        //{
        //    return;
        //}
        itemBuyQuantity++;

    //    itemBuyQuantity.text = itemBuyQuantity.ToString();
        //sellQuantity = 
    }
    public void DecreaseItemSellQuantity()
    {
        if (itemBuyQuantity <= 1)
        {
            Debug.Log("reached min quantity");
            return;
        }
        //itemSellQuantity--;
        //itemQuantityText.text = itemSellQuantity.ToString();
    }
}
