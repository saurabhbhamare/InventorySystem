using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ItemSOList",menuName ="CreateScriptableObject/CreateItemSOList")]

public class ItemSOList : ScriptableObject
{
    public List<ItemSO> InventoryItems;
}
