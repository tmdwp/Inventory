using System.Collections;
using System.Collections.Generic;
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

    void Start()
    {
        if(id == null) id = "NoName";
        renderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeSkin(CharacterColor change)
    {
        color = change;
        renderer.sprite = skin[(int)color];
    }
}
