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

    //���� ���Կ� �� ������ ���� ����
    public void SetItem(ItemData item)
    {
        curItem = item;
        RefreshSlot();
    }

    //������ ������ ��������Ʈ ����
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

    //��� ����
    public void DoEquip()
    {
        Debug.Log("Click");
        if (isEquip) GameManager.Instance.player.UnEquip(); //������ �����ߴ� ��� ����
        else GameManager.Instance.player.Equip(this);
    }

    //���� ǥ�� Ȱ��ȭ
    public void ActiveEquipped()
    {
        equippedSlot.gameObject.SetActive(true);
    }

    //���� ǥ�� ��Ȱ��ȭ
    public void DisactiveEquipped()
    {
        equippedSlot.gameObject.SetActive(false);
    }
}
