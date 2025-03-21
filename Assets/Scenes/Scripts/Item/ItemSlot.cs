using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class ItemSlot : MonoBehaviour
{
    public ItemData item;
    Image renderer;
    [SerializeField] private Image equippedSlot;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Image>();
        equippedSlot = GetComponentInChildren<Image>(true);
        if (item != null)
        {
            RefreshSlot();
        }
        else gameObject.SetActive(false);
    }

    public void RefreshSlot()
    {
        renderer.sprite = item.sprite;
        if (item.equiped)
        {
            equippedSlot.gameObject.SetActive(true);
        }
        else
        {
            equippedSlot.gameObject.SetActive(false);
        }
    }

    public void OnClick()
    {
        if (item.equiped) item.equiped = false;
        else item.equiped = true;
        RefreshSlot();
    }
}
