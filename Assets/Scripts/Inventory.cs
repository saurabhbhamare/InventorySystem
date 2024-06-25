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
        private List<ItemSlot> itemSlotList;
       private float inventoryWeight;
        private int inventoryValue;
        private int itemID;
    private void Start()
    {
        itemSlotList = new List<ItemSlot>();
       
    }
    public void AddItem()
    {
        int randomSO = Random.Range(0, itemSOList.InventoryItems.Count);
        itemID = itemSOList.InventoryItems[randomSO].ItemID;
        inventoryWeight += itemSOList.InventoryItems[itemID].ItemWeight;
        inventoryWeightText.text = inventoryWeight.ToString();
        //Debug.Log(" This id RandomSO " + randomSO);
        //Debug.Log(" This is itemID " + itemID);
        //Debug.Log(" first Item ID is " + itemID);
        //Debug.Log(itemSlotList.Count);
        if (itemSlotList.Count ==0)
        {
            Debug.Log("running function for the first slot");
            ItemSlot firstItemSlot = Instantiate(itemSlot, parent.transform);
            firstItemSlot.itemID = itemID;
            //Debug.Log("item id " + itemID);
            //Debug.Log("item id " + randomSO);
            firstItemSlot.itemQuantity++;
            firstItemSlot.itemName = itemSOList.InventoryItems[itemID].ItemName;
            firstItemSlot.itemImage.sprite = itemSOList.InventoryItems[itemID].ItemSprite;
            firstItemSlot.quantityText.text = firstItemSlot.itemQuantity.ToString();
            itemSlotList.Add(firstItemSlot); 
            Debug.Log(firstItemSlot.itemName + " ID ->" + itemID);
            return;
        }
        foreach (var existingSlot in itemSlotList)
        {
            if (existingSlot.itemID == itemID)
            {
                existingSlot.itemQuantity++;
                existingSlot.quantityText.text = existingSlot.itemQuantity.ToString();
                return;
            }
        }

        ItemSlot spawnedItemSlot = Instantiate(itemSlot, parent.transform);
        spawnedItemSlot.itemQuantity =1;
        spawnedItemSlot.itemID = itemID;
        spawnedItemSlot.itemImage.sprite = itemSOList.InventoryItems[randomSO].ItemSprite;
        spawnedItemSlot.itemName = itemSOList.InventoryItems[randomSO].ItemName;
        spawnedItemSlot.quantityText.text = spawnedItemSlot.itemQuantity.ToString();
        itemSlotList.Add(spawnedItemSlot);
        
        Debug.Log(spawnedItemSlot.itemName+" ID ->"+ itemID);
       
    }
}






//for(int i = 0; i < itemSlotList.Count; i++)
//{
//    if()
//}




//int randomNumber = Random.Range(MIN_ITEMS, MAX_ITEMS);
//GameObject itemGameObject = Instantiate(prefab, parent.transform);
//string itemName = itemSOList.InventoryItems[randomNumber].ItemName;
//Sprite itemSprite = itemSOList.InventoryItems[randomNumber].ItemSprite;
//itemGameObject.GetComponent<ItemSlot>().SetItemInfo(itemSprite, itemName);
//itemList.Add(itemGameObject);























//-------------------------------------------------------------

//public void Add()
//{
//    int pickRandomItemNumber = Random.Range(0, 20);
//    ItemSO itemSO = itemSOList.InventoryItems[pickRandomItemNumber];

//    for(int i = 0; i < itemList.Count; i++)
//    {
//        if(itemSO.name == itemList[i].name)
//        {
//            itemList[i].ItemQuantity++;
//            ShowAllInventoryItems();
//            return;
//        }
//    }
//    AddItemToTheUI(itemSO);

//}
//public void ShowItemDescription(ItemSO itemSO)
//{

//}
//public void ShowAllInventoryItems()
//{

//}
//public void AddItemToTheUI(ItemSO itemSO)
//{
//    GameObject item = Instantiate(prefab, parent.transform);
//    item.GetComponent<ItemSlot>().SetItemSO(itemSO);
//}