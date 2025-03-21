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


    public CharacterColor color;
    [SerializeField] private Sprite[] skin;
    private SpriteRenderer renderer;

    [Header("Canvas")]
    public TextMeshProUGUI nameTxt;
    public TextMeshProUGUI lvTxt;
    public TextMeshProUGUI goldTxt;

    private static Player _instance;
    public static Player Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("Player").AddComponent<Player>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
    }

    void Start()
    {
        if(id == "") id = "NoName";
        renderer = GetComponent<SpriteRenderer>();
        UpdateStat();
    }

    public void UpdateStat()
    {
        nameTxt.text = id;
        lvTxt.text = level.ToString();
        goldTxt.text = gold.ToString();
    }

    public void ChangeSkin(CharacterColor change)
    {
        color = change;
        renderer.sprite = skin[(int)color];
    }

    public float GetHp(){ return hp;  }
    public float GetAttack() {  return attack; }
    public float GetDefense() { return defense; }
    public float GetCritical() { return critical; }
}
