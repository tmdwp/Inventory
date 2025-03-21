using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class ItemSlot : MonoBehaviour
{
    public ItemData curItem;
    Image renderer;
    [SerializeField] private Image equippedSlot;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Image>();
        equippedSlot = GetComponentInChildren<Image>(true);

        RefreshSlot();
    }
    public void SetItem(ItemData item)
    {
        curItem = item;
        RefreshSlot();
    }

    public void RefreshSlot()
    {
        if (curItem != null)
        {
            renderer.sprite = curItem.sprite;
        }
        else
        {
            renderer.sprite = null;
        }
    }

    public void OnClick()
    {
        if (curItem.equiped) curItem.equiped = false;
        else curItem.equiped = true;
        RefreshSlot();
    }
}
