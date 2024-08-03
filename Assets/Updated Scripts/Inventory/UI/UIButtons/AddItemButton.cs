using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItemButton : MonoBehaviour
{
    [SerializeField] private InventoryView inventoryView;
    [SerializeField] private ItemView itemView;

    public void AddItem(ItemView itemView)
    {
        inventoryView.GetInventoryController().AddItemToTheInventory(itemView);
    }
      
}
