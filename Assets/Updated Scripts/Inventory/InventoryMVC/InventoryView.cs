using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class InventoryView : MonoBehaviour
{
    public InventoryController inventoryController;
    public  GameObject parentTransform;
    [SerializeField] private TextMeshProUGUI inventoryWeightText;
    public InventoryView()
    {
        Debug.Log("created a inventory view");
    }
    public InventoryController GetInventoryController()
    {
        return inventoryController;
    }
    public void SetInventoryController(InventoryController inventoryController)
    {
        this.inventoryController = inventoryController; 
    }
    public TextMeshProUGUI GetInventoryWeightTextGUI()
    {
        return inventoryWeightText;
    }
}