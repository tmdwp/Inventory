using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum CharacterColor
{
    White,
    Red,
    Yellow,
    Green,
    Blue
}

public class Player : MonoBehaviour
{
    public string id;

    public int gold;

    [Header("Status")]
    public int level;
    public float hp;
    public float attack;
    public float defense;
    public float critical;

    [Header("Item")]
    public List<ItemData> inventory;

    public CharacterColor color;
    [SerializeField] private Sprite[] skin;
    private SpriteRenderer renderer;


    public Player(string id)
    {
        this.id = id;
        level = 1;
        gold = 500;
        hp = 100;
        attack = 10;
        defense = 10;
        critical = 15;
    }

    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeSkin(CharacterColor change)
    {
        color = change;
        renderer.sprite = skin[(int)color];
    }

    public float GetHpFromPlayer(){ return hp;  }
    public float GetAttackFromPlayer() {  return attack; }
    public float GetDefenseFromPlayer() { return defense; }
    public float GetCriticalFromPlayer() { return critical; }
}
