using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Inventory : MonoBehaviour
{
        [SerializeField] private ItemSOList itemSOList; 
        [SerializeField] private Transform parent;
        [SerializeField] private ItemSlot itemSlot;
        [SerializeField] private TextMeshProUGUI inventoryWeightText;
    
        [SerializeField] private DescriptionPanel descriptionPanel;
        public Dictionary<int , ItemSlot> itemSlotList;
        private float inventoryWeight;
        private int inventoryValue;
        private int itemID;
    private void Awake()
    {
       itemSlotList = new Dictionary<int, ItemSlot>();
    }
    public void AddItem()
    {
        int pickRandomSO = Random.Range(0, itemSOList.InventoryItems.Count);
        int itemID = itemSOList.InventoryItems[pickRandomSO].ItemID;
        inventoryWeight += itemSOList.InventoryItems[itemID].ItemWeight;
        if( itemSlotList.Count == 0 )
        {
            Debug.Log(itemSOList.InventoryItems[pickRandomSO].ItemName);
            CreateNewItemSlotUI(itemID);
        }
        else if (itemSlotList.TryGetValue(itemID, out var existingSlot))
        {
            existingSlot.itemQuantity++;
            Debug.Log("created a " + existingSlot.itemName + "again");
            existingSlot.UpdateItemSlotQuantity(existingSlot.itemQuantity);
        }
        else
        {
            CreateNewItemSlotUI(itemID);
        }
    }
    private void CreateNewItemSlotUI(int itemID)
    {
        ItemSlot newItemSlot = Instantiate(itemSlot, parent.transform);   

        newItemSlot.name = itemSOList.InventoryItems[itemID].ItemName;
        newItemSlot.itemName = itemSOList.InventoryItems[itemID].ItemName;
        newItemSlot.itemDescription = itemSOList.InventoryItems[itemID].ItemDescription;
        Debug.Log("newly created Item name is " + itemSOList.InventoryItems[itemID].ItemName);
        newItemSlot.itemImage.sprite = itemSOList.InventoryItems[itemID].ItemSprite;
        newItemSlot.itemSelllingPrice = itemSOList.InventoryItems[itemID].ItemSellingPrice;
        newItemSlot.itemQuantity++; 
        newItemSlot.gameObject.SetActive(true);
        newItemSlot.UpdateItemSlotQuantity(newItemSlot.itemQuantity);
        itemSlotList.Add(itemID, newItemSlot);
    }
}
