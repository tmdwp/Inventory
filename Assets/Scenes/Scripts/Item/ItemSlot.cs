using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class ItemSlot : MonoBehaviour
{
    public ItemData item;
    Image renderer;
    [SerializeField] private GameObject equippedSlot;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Image>();
        if (item != null)
        {
            UpdateSlot();
        }
        else gameObject.SetActive(false);
    }

    public void UpdateSlot()
    {
        renderer.sprite = item.sprite;
        if (item.equiped)
        {
            equippedSlot.SetActive(true);
        }
        else
        {
            equippedSlot.SetActive(false);
        }
    }

    public void OnClick()
    {
        if (item.equiped) item.equiped = false;
        else item.equiped = true;
        UpdateSlot();
    }
}
