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
    public int level;
    public int gold;
    public float hp;
    public CharacterColor color;
    [SerializeField] private Sprite[] skin;
    private SpriteRenderer renderer;

    [Header("Canvas")]
    public TextMeshProUGUI nameTxt;
    public TextMeshProUGUI lvTxt;
    public TextMeshProUGUI goldTxt;

    void Start()
    {
        if(id == null) id = "NoName";
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
}
