using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;


public class AddItemButton : MonoBehaviour
{
    [SerializeField] private InventoryView inventoryView;
    [SerializeField] private ItemView itemView;
    public Action action;
    public UnityAction unityAction;
    public UnityEvent unityEvent;

    public void AddItem(ItemView itemView)
    {
        inventoryView.GetInventoryController().AddItemToTheInventory(itemView);
    }
      
}
