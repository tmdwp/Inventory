using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public ItemSlot equiped;
    public List<ItemSlot> slots;
    public GameObject slot;
    public Transform slotsParent;
    
    public Button back;
    void Start()
    {
        InitInventoryUI();
        back.onClick.AddListener(UIManager.UiManager.CloseInven);
    }

    public void InitInventoryUI()
    {
        List<ItemData> items = GameManager.Instance.player.inventory;

        
        foreach (Transform child in slotsParent)
        {
            Destroy(child.gameObject);
        }
        slots.Clear();

        
        foreach (var item in items)
        {
            GameObject newSlotObj = Instantiate(slot, slotsParent);
            ItemSlot newSlot = newSlotObj.GetComponent<ItemSlot>();
            slots.Add(newSlot);
            newSlot.SetItem(item);
        }
    }
}
