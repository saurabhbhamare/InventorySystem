using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class InventoryView : MonoBehaviour
{
    public InventoryController inventoryController;
    public  GameObject parentTransform;
    [SerializeField] private TextMeshProUGUI inventoryWeightText;
    public InventoryController GetInventoryController() => inventoryController;
    public void SetInventoryController(InventoryController inventoryController)
    {
        this.inventoryController = inventoryController; 
    }
    public TextMeshProUGUI GetInventoryWeightTextGUI()
    {
        return inventoryWeightText;
    }
}