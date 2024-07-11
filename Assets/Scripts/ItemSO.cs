using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName ="ItemSO",menuName ="CreateScriptableObject/Item/ItemSO")]
public class ItemSO : ScriptableObject
{
    public int ItemID;
    public string ItemName; 
    public Sprite ItemSprite;
    public ItemType ItemType;
    public ItemRarity ItemRarity;
    public float ItemWeight;
    public int ItemBuyingPrice;
    public int ItemSellingPrice;
    [TextArea] public string ItemDescription;
}
