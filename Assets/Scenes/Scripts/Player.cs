using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Player
{
    public string id;

    public int gold;

    public int level { get; private set; }
    public float hp { get; private set; }
    public float attack { get; private set; }
    public float defense { get; private set; }
    public float critical { get; private set; }

    [Header("Item")]
    public List<ItemData> inventory;
    public CharacterColor color;
    public ItemSlot equip;

    public Player(string ID, Sprite sprite)
    {
        id = ID;
        level = 1;
        gold = 500;
        hp = 100f;
        attack = 10f;
        defense = 10f;
        critical = 15f;
        inventory = new List<ItemData>();
    }


    public void GetItem(ItemData item)
    {
        inventory.Add(item);
    }

    public void Equip(ItemSlot item)
    {
        if(equip!= null && equip.curItem.name != item.name)
        {
            UnEquip();
            equip = null;
        }
        equip = item;
        equip.isEquip = true;
        hp += equip.curItem.hp;
        attack += equip.curItem.attack;
        defense += equip.curItem.defense;
        critical += equip.curItem.critical;
        equip.ActiveEquipped();
        equip.RefreshSlot();
        UIManager.UiManager.status.UpdateStatTxt();
    }

    public void UnEquip()
    {
        hp -= equip.curItem.hp;
        attack -= equip.curItem.attack;
        defense -= equip.curItem.defense;
        critical -= equip.curItem.critical;
        equip.DisactiveEquipped();
        equip.isEquip = false;
        equip.RefreshSlot();
        UIManager.UiManager.status.UpdateStatTxt();
        equip = null;
    }

    public float GetHpFromPlayer(){ return hp;  }
    public float GetAttackFromPlayer() {  return attack; }
    public float GetDefenseFromPlayer() { return defense; }
    public float GetCriticalFromPlayer() { return critical; }
}
