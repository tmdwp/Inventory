using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Image;
public class ItemSlot : MonoBehaviour
{
    public ItemData curItem;
    Image renderer;
    [SerializeField] private Image equippedSlot;
    public Sprite origin;
    public bool isEquip;
    public Button equipBtn;

    void Start()
    {
        Debug.Log(TryGetComponent<Image>(out renderer));
        origin = renderer.sprite;
        equipBtn.onClick.AddListener(DoEquip);
        RefreshSlot();
    }

    //현재 슬롯에 들어갈 아이템 정보 저장
    public void SetItem(ItemData item)
    {
        curItem = item;
        RefreshSlot();
    }

    //아이템 슬롯의 스프라이트 변경
    public void RefreshSlot()
    {
        renderer = GetComponent<Image>();
        if (curItem != null)
        {
            renderer.sprite = curItem.sprite;
        }
        else
        {
            renderer.sprite = origin;
        }
    }

    //장비 장착
    public void DoEquip()
    {
        Debug.Log("Click");
        if (isEquip) GameManager.Instance.player.UnEquip(); //기존에 장착했던 장비 해제
        else GameManager.Instance.player.Equip(this);
    }

    //장착 표시 활성화
    public void ActiveEquipped()
    {
        equippedSlot.gameObject.SetActive(true);
    }

    //장착 표시 비활성화
    public void DisactiveEquipped()
    {
        equippedSlot.gameObject.SetActive(false);
    }
}
